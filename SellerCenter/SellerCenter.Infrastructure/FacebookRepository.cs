namespace SellerCenter.Infrastructure
{
    public class FacebookRepository
    {
        public async Task<string> PostFacebookAsync(string pageId, string pageToken, string message)
        {
            using var client = new HttpClient();

            var url = $"https://graph.facebook.com/v25.0/{pageId}/feed";

            var data = new Dictionary<string, string>
            {
                { "message", message },
                { "access_token", pageToken }
            };

            var response = await client.PostAsync(url, new FormUrlEncodedContent(data));
            var result = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
                throw new Exception(result);

            return result;
        }
    }
}