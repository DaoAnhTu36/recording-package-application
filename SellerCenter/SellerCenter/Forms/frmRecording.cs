using OpenCvSharp;
using OpenCvSharp.Extensions;
using SellerCenter.Helper;
using SellerCenter.Infrastructure;
using SellerCenter.Service;

namespace SellerCenter.Forms
{
    public partial class frmRecording : Form
    {
        private VideoCapture _camera;
        private VideoWriter _writer;
        private int _width;
        private int _height;
        private bool _isSaveIntoDatabase = true;
        private CancellationTokenSource? _cts;
        private Task? _recordTask;
        private readonly object _writerLock = new(); private CancellationTokenSource _checkCts;
        private Task _checkTask;

        public frmRecording()
        {
            InitializeComponent();
            _camera = new VideoCapture(0);
            _width = (int)_camera.Get(VideoCaptureProperties.FrameWidth);
            _height = (int)_camera.Get(VideoCaptureProperties.FrameHeight);
        }

        private void btnCheckOrder_Click(object sender, EventArgs e)
        {
            CheckOrder();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartRecording();
        }

        private async void btnEnd_Click(object sender, EventArgs e)
        {
            await StopRecordingAsync();
        }

        private void StartRecording()
        {
            if (_recordTask != null && !_recordTask.IsCompleted) return;

            _cts = new CancellationTokenSource();
            btnStart.Enabled = false;
            btnEnd.Enabled = true;
            historyScanBarcode.Items.Add($"{DateTime.Now:HH:mm:ss} - Bắt đầu quay video.");

            _recordTask = Task.Run(() => RecordLoop(_cts.Token));
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

        private void CheckOrder()
        {
            historyScanBarcode.Items.Add($"{DateTime.Now:HH:mm:ss} - Hãy quét mã đơn hàng.");
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

                    var qrHelper = new QrScannerHelper();
                    var barcode = qrHelper.DecodeQR(frame);

                    if (!string.IsNullOrEmpty(barcode))
                    {
                        var packingSessionService = new PackingSessionRepository();
                        if (packingSessionService.IsBarcodeExists(barcode))
                        {
                            historyScanBarcode.Invoke((MethodInvoker)(() =>
                            {
                                historyScanBarcode.Items.Add($"{DateTime.Now:HH:mm:ss} - Mã QR {barcode} đã tồn tại.");
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
                                    btnCheckOrder.Enabled = false;
                                    historyScanBarcode.Items.Add($"{DateTime.Now:HH:mm:ss} - Sẵn sàng quay video.");
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
            historyScanBarcode.Items.Add($"{DateTime.Now:HH:mm:ss} - Đã dừng quay video.");
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

        private bool ConfigOutputVideo(string? barcode)
        {
            lock (_writerLock)
            {
                _writer?.Release();
                _writer?.Dispose();
                _writer = null;
                var fileName = Utilities.CreateFileName(barcode, out bool isSuccess);
                var fullPath = Utilities.CreatePath(Application.StartupPath, fileName, out isSuccess);

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
                    if (barcode != null)
                    {
                        var packingSessionService = new PackingSessionService();
                        packingSessionService.InsertSession(barcode, fullPath);
                    }
                }

                return true;
            }
        }

        private void frmRecording_Load(object sender, EventArgs e)
        {
        }
    }
}