using SellerCenter.Infrastructure;

namespace SellerCenter.Service
{
    public class GoogleDriverService
    {
        private readonly GoogleDriverRepository _googleDriverRepository;

        public GoogleDriverService(GoogleDriverRepository googleDriverRepository)
        {
            _googleDriverRepository = googleDriverRepository;
        }

        public async Task<string> UploadVideoToDrive(string filePath)
        {
            return await _googleDriverRepository.UploadVideoToDrive(filePath);
        }
    }
}