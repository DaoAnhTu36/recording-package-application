using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Upload;
using Google.Apis.Util.Store;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using SellerCenter.Helper;
using SellerCenter.Helpers;
using SellerCenter.Service;

namespace SellerCenter.Forms
{
    public partial class frmRecording : BaseForm
    {
        private readonly IPackingSessionService _packingSessionService;
        private VideoCapture _camera;
        private VideoWriter? _writer;
        private int _width;
        private int _height;
        private string? _fullPathFile;
        private string? _fullNameFile;
        private bool _isSaveIntoDatabase = true;
        private CancellationTokenSource? _cts;
        private Task? _recordTask;
        private readonly object _writerLock = new();
        private CancellationTokenSource? _checkCts;
        private Task? _checkTask;
        private string? _barcode;

        public frmRecording()
        {
            InitializeComponent();
            _packingSessionService = ServiceLocator.Get<IPackingSessionService>();
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
                while (!_checkCts!.Token.IsCancellationRequested)
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
                        if (_packingSessionService.IsBarcodeExists(barcode))
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
            btnUploadYoutube.Enabled = true;
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
                _fullNameFile = Utilities.CreateFileName(barcode, out bool isSuccess);
                _fullPathFile = Utilities.CreatePath(Application.StartupPath, _fullNameFile, out isSuccess);

                _writer = new VideoWriter(
                    _fullPathFile,
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
                        _barcode = barcode;
                        _packingSessionService.InsertSession(barcode, _fullPathFile!);
                    }
                }

                return true;
            }
        }

        private async void btnUploadYoutube_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_fullPathFile) || string.IsNullOrWhiteSpace(_fullNameFile) || !File.Exists(_fullPathFile))
            {
                MessageBox.Show("File video không tồn tại. Vui lòng quay video trước khi upload.");
                return;
            }

            try
            {
                btnUploadYoutube.Enabled = false;
                progressBar1.Visible = true;
                progressBar1.Value = 0;
                lblStatus.Visible = true;
                lblStatus.Text = "Đang xác thực Google...";

                await UploadVideoAsync(
                    _fullPathFile!,
                    _fullNameFile!,
                    _fullNameFile!
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                lblStatus.Text = "Upload thất bại";
            }
            finally
            {
                btnUploadYoutube.Enabled = true;
            }
        }

        private async Task UploadVideoAsync(string filePath, string title, string description)
        {
            if (string.IsNullOrWhiteSpace(filePath) || !File.Exists(filePath))
                throw new Exception("File video không tồn tại.");

            UserCredential credential;

            using (var stream = new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
            {
                credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.FromStream(stream).Secrets,
                    new[] { YouTubeService.Scope.YoutubeUpload },
                    "user",
                    CancellationToken.None,
                    new FileDataStore("YouTubeUploader.Auth.Store")
                );
            }

            var youtubeService = new YouTubeService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "YouTube Upload WinForms"
            });

            var video = new Video();
            video.Snippet = new VideoSnippet
            {
                Title = title,
                Description = description,
                CategoryId = "22" // People & Blogs
            };

            video.Status = new VideoStatus
            {
                PrivacyStatus = "public" // private | public | unlisted
            };

            using (var fileStream = new FileStream(filePath, FileMode.Open))
            {
                var request = youtubeService.Videos.Insert(video, "snippet,status", fileStream, "video/*");

                request.ProgressChanged += Request_ProgressChanged;
                request.ResponseReceived += Request_ResponseReceived;

                await request.UploadAsync();
            }
        }

        private void Request_ProgressChanged(IUploadProgress progress)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => Request_ProgressChanged(progress)));
                return;
            }

            switch (progress.Status)
            {
                case UploadStatus.Starting:
                    lblStatus.Text = "Bắt đầu upload...";
                    break;

                case UploadStatus.Uploading:
                    lblStatus.Text = $"Đang upload: {progress.BytesSent / 1024 / 1024} MB";
                    if (progressBar1.Value < 90)
                        progressBar1.Value = Math.Min(progressBar1.Value + 5, 90);
                    break;

                case UploadStatus.Completed:
                    progressBar1.Value = 100;
                    lblStatus.Text = "Upload thành công";
                    break;

                case UploadStatus.Failed:
                    lblStatus.Text = "Upload thất bại: " + progress.Exception?.Message;
                    break;
            }
        }

        private void Request_ResponseReceived(Video video)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => Request_ResponseReceived(video)));
                return;
            }

            string youtubeUrl = $"https://www.youtube.com/watch?v={video.Id}";
            lblStatus.Text = youtubeUrl;
            _packingSessionService.UpdateSession(_barcode!, youtubeUrl);
        }

        private void frmRecording_Load(object sender, EventArgs e)
        {
            btnCheckOrder.Enabled = true;
            LayoutHelper.SetupEqualTable(tableLayoutPanel1, 4, 3);
        }
    }
}