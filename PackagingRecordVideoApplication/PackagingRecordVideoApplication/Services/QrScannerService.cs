using OpenCvSharp;
using OpenCvSharp.Extensions;
using ZXing.Windows.Compatibility;

namespace PackagingRecordVideoApplication.Services
{
    public class QrScannerService
    {
        public string DecodeQR(Mat frame)
        {
            using Bitmap bitmap = BitmapConverter.ToBitmap(frame);

            var reader = new BarcodeReader
            {
                AutoRotate = true
            };

            var result = reader.Decode(bitmap);
            return result?.Text ?? "";
        }
    }
}