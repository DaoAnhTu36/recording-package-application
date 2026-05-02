using OpenCvSharp;
using OpenCvSharp.Extensions;
using System.Drawing;

namespace SellerCenter.Service.Implementation
{
    public class CameraService : ICameraService
    {
        private VideoCapture _capture;
        private VideoWriter _writer;
        private bool _isRecording = false;
        private bool _isRunning = false;
        private Action<Bitmap> _onFrame;

        public void StartCamera(Action<Bitmap> onFrame)
        {
            _capture = new VideoCapture(0);
            _isRunning = true;

            Task.Run(() =>
            {
                var frame = new Mat();

                while (_isRunning)
                {
                    _capture.Read(frame);

                    if (!frame.Empty())
                    {
                        var bitmap = BitmapConverter.ToBitmap(frame)!;
                        onFrame?.Invoke(bitmap);
                    }
                }
            });
        }

        public void StartRecording(string filePath)
        {
            if (_capture == null)
                throw new Exception("Camera chưa start");

            int width = _capture.FrameWidth > 0 ? (int)_capture.FrameWidth : 640;
            int height = _capture.FrameHeight > 0 ? (int)_capture.FrameHeight : 480;

            _writer = new VideoWriter(
                filePath,
                FourCC.MP4V,
                20,
                new OpenCvSharp.Size(width, height)
            );

            _isRecording = true;
        }

        public void StopRecording()
        {
            _isRecording = false;

            _writer?.Release();
            _writer?.Dispose();
            _writer = null;
        }

        public void StopCamera()
        {
            _isRunning = false;

            _capture?.Release();
            _capture?.Dispose();
            _capture = null;
        }
    }
}