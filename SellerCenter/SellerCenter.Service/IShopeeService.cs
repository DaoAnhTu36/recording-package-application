namespace SellerCenter.Service
{
    public interface IShopeeService
    {
        public Task<string> GetAccessTokenAsync(string code, long shopId);

        public Task<string> GetShopInfoAsync(string accessToken, long shopId);
    }
}