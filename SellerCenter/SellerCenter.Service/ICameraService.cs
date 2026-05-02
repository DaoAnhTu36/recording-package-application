using System.Drawing;

namespace SellerCenter.Service
{
    public interface ICameraService
    {
        void StartCamera(Action<Bitmap> onFrame);

        void StartRecording(string filePath);

        void StopRecording();

        void StopCamera();
    }
}