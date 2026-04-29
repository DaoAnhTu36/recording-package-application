using SellerCenter.Infrastructure;

namespace SellerCenter.Service
{
    public class FacebookService
    {
        private readonly FacebookRepository _facebookRepository;

        public FacebookService()
        {
            _facebookRepository = new FacebookRepository();
        }

        public async Task<string> PostFacebookAsync(string pageId, string pageToken, string message)
        {
            return await _facebookRepository.PostFacebookAsync(pageId, pageToken, message);
        }

        public async Task<string> PostVideoToFacebookAsync(string pageId, string pageToken, string videoPath, string description)
        {
            return await _facebookRepository.PostVideoToFacebookAsync(pageId, pageToken, videoPath, description);
        }
    }
}