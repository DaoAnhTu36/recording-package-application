using OpenCvSharp;
using OpenCvSharp.Extensions;
using PackagingRecordVideoApplication.Services;
using System.Text.RegularExpressions;
using System.Windows.Controls;
using System.Windows.Media.Media3D;
using ZXing;
using ZXing.PDF417.Internal;
using ZXing.QrCode.Internal;
using ZXing.Windows.Compatibility;

namespace PackagingRecordVideoApplication
{
    public partial class Form1 : Form
    {
        private VideoCapture _camera;
        private int _width;
        private int _height;
        private VideoWriter _writer;
        private PackingSessionService _packingSessionService;
        private bool _isSaveIntoDatabase = true;
        private CancellationTokenSource? _cts;
        private Task? _recordTask;
        private readonly object _writerLock = new(); private CancellationTokenSource _checkCts;
        private Task _checkTask;
        private QrScannerService _qrService = new QrScannerService();

        public Form1()
        {
            InitializeComponent();
            _camera = new VideoCapture(0);
            _width = (int)_camera.Get(VideoCaptureProperties.FrameWidth);
            _height = (int)_camera.Get(VideoCaptureProperties.FrameHeight);
        }

        private void RecordLoop(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                using var frame = new Mat();
                _camera.Read(frame);

                if (frame.Empty())
                {
                    Thread.Sleep(10);
                    continue;
                }

                var bitmap = BitmapConverter.ToBitmap(frame);

                pictureBoxCamera.Invoke((MethodInvoker)(() =>
                {
                    var old = pictureBoxCamera.Image;
                    pictureBoxCamera.Image = bitmap;
                    old?.Dispose();
                }));

                lblRecordStatus.Invoke((MethodInvoker)(() =>
                {
                    lblRecordStatus.Text = "Đang quay video đóng hàng.";
                }));

                lock (_writerLock)
                {
                    if (_writer != null && _writer.IsOpened())
                    {
                        _writer.Write(frame);
                    }
                }

                Thread.Sleep(10);
            }
        }

        private void StartRecording()
        {
            if (_recordTask != null && !_recordTask.IsCompleted) return;

            _cts = new CancellationTokenSource();
            btnStart.Enabled = false;
            btnEnd.Enabled = true;

            _recordTask = Task.Run(() => RecordLoop(_cts.Token));
        }

        private void CheckOrder()
        {
            _checkCts = new CancellationTokenSource();

            _checkTask = Task.Run(() =>
            {
                while (!_checkCts.Token.IsCancellationRequested)
                {
                    using var frame = new Mat();
                    _camera.Read(frame);

                    if (frame.Empty())
                    {
                        Thread.Sleep(10);
                        continue;
                    }

                    var bmp = BitmapConverter.ToBitmap(frame);
                    pictureBoxCamera.Invoke((MethodInvoker)(() =>
                    {
                        var old = pictureBoxCamera.Image;
                        pictureBoxCamera.Image = bmp;
                        old?.Dispose();
                    }));

                    var barcode = _qrService.DecodeQR(frame);

                    if (!string.IsNullOrEmpty(barcode))
                    {
                        if (_packingSessionService.IsBarcodeExists(barcode))
                        {
                            historyScanBarcode.Invoke((MethodInvoker)(() =>
                            {
                                historyScanBarcode.Items.Add($"{DateTime.Now:HH:mm:ss} - Mã QR {barcode} đã tồn tại.");
                                historyScanBarcode.TopIndex = historyScanBarcode.Items.Count - 1;
                            }));
                        }
                        else
                        {
                            if (ConfigOutputVideo(barcode))
                            {
                                BeginInvoke((MethodInvoker)(() =>
                                {
                                    lblBarcodeScan.Text = barcode;
                                    lblRecordStatus.Text = "Sẵn sàng quay video";
                                    btnStart.Enabled = true;
                                }));

                                break;
                            }
                        }
                    }

                    Thread.Sleep(30);
                }
            });
        }

        private async Task StopRecordingAsync()
        {
            btnCheckOrder.Enabled = true;
            btnStart.Enabled = false;
            btnEnd.Enabled = false;
            _cts?.Cancel();

            if (_recordTask != null)
            {
                await _recordTask;
                _recordTask = null;
            }

            lock (_writerLock)
            {
                if (_writer != null)
                {
                    _writer.Release();
                    _writer.Dispose();
                    _writer = null;
                }
            }

            lblBarcodeScan.Text = "Vui lòng quét mã vạch";
            lblRecordStatus.Text = "Không sẵn sàng quay video";
        }

        private void GetListVideoFiles()
        {
            var videos = _packingSessionService.GetAllSessions();
            dgvFileVideo.Invoke((MethodInvoker)(() =>
            {
                dgvFileVideo.DataSource = videos;
            }));
        }

        private bool ConfigOutputVideo(string? barcode)
        {
            lock (_writerLock)
            {
                _writer?.Release();
                _writer?.Dispose();
                _writer = null;

                string basePath = Path.Combine(Application.StartupPath, "Videos");
                string dateFolder = DateTime.Now.ToString("yyyy-MM-dd");
                string folderPath = Path.Combine(basePath, dateFolder);
                Directory.CreateDirectory(folderPath);

                string fileName = $"ORDER_{barcode}_{DateTime.Now:HHmmss}.mp4";
                string fullPath = Path.Combine(folderPath, fileName);

                _writer = new VideoWriter(
                    fullPath,
                    FourCC.MP4V,
                    30,
                    new OpenCvSharp.Size(_width, _height)
                );

                if (!_writer.IsOpened())
                {
                    historyScanBarcode.Invoke((MethodInvoker)(() =>
                    {
                        historyScanBarcode.Items.Add($"{DateTime.Now:HH:mm:ss} - Không tạo được file video");
                    }));
                    return false;
                }

                if (_isSaveIntoDatabase)
                {
                    _packingSessionService.InsertSession(barcode, fullPath);
                }

                return true;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartRecording();
        }

        private async void btnEnd_Click(object sender, EventArgs e)
        {
            await StopRecordingAsync();
            GetListVideoFiles();
        }

        private void btnCheckOrder_Click(object sender, EventArgs e)
        {
            CheckOrder();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _packingSessionService = new PackingSessionService();
            var videos = _packingSessionService.GetAllSessions();
            dgvFileVideo.DataSource = videos;
        }
    }
}