namespace SellerCenter.Service
{
    public interface IGoogleService
    {
        public Task<string> UploadVideoToDrive(string filePath);
    }
}