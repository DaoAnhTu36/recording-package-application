namespace SellerCenter.Service
{
    public interface IFacebookService
    {
        public Task<string> PostFacebookAsync(string pageId, string pageToken, string message);

        public Task<string> PostVideoToFacebookAsync(string pageId, string pageToken, string videoPath, string description);
    }
}