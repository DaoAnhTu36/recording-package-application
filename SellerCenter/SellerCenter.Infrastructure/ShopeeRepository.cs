using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace SellerCenter.Infrastructure
{
    public class ShopeeRepository
    {
        private readonly string _baseUrl = "https://partner.shopeemobile.com";
        private readonly long _partnerId;
        private readonly string _partnerKey;
        private readonly HttpClient _http;

        public ShopeeRepository(long partnerId, string partnerKey)
        {
            _partnerId = partnerId;
            _partnerKey = partnerKey;
            _http = new HttpClient();
        }

        private long GetTimestamp() =>
            DateTimeOffset.UtcNow.ToUnixTimeSeconds();

        private string Sign(string baseString)
        {
            using var hmac = new HMACSHA256(Encoding.UTF8.GetBytes(_partnerKey));
            var hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(baseString));
            return BitConverter.ToString(hash).Replace("-", "").ToLower();
        }

        public string BuildAuthUrl(string redirectUrl)
        {
            var path = "/api/v2/shop/auth_partner";
            var timestamp = GetTimestamp();

            var baseString = $"{_partnerId}{path}{timestamp}";
            var sign = Sign(baseString);

            return $"{_baseUrl}{path}?partner_id={_partnerId}&timestamp={timestamp}&sign={sign}&redirect={Uri.EscapeDataString(redirectUrl)}";
        }

        public async Task<string> GetAccessTokenAsync(string code, long shopId)
        {
            var path = "/api/v2/auth/token/get";
            var timestamp = GetTimestamp();

            var baseString = $"{_partnerId}{path}{timestamp}";
            var sign = Sign(baseString);

            var url = $"{_baseUrl}{path}?partner_id={_partnerId}&timestamp={timestamp}&sign={sign}";

            var payload = new
            {
                code = code,
                shop_id = shopId,
                partner_id = _partnerId
            };

            var json = JsonSerializer.Serialize(payload);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _http.PostAsync(url, content);
            var responseText = await response.Content.ReadAsStringAsync();

            response.EnsureSuccessStatusCode();
            return responseText;
        }

        public async Task<string> GetShopInfoAsync(string accessToken, long shopId)
        {
            var path = "/api/v2/shop/get_shop_info";
            var timestamp = GetTimestamp();

            var baseString = $"{_partnerId}{path}{timestamp}{accessToken}{shopId}";
            var sign = Sign(baseString);

            var url = $"{_baseUrl}{path}?partner_id={_partnerId}&timestamp={timestamp}&access_token={accessToken}&shop_id={shopId}&sign={sign}";

            var response = await _http.GetAsync(url);
            var responseText = await response.Content.ReadAsStringAsync();

            response.EnsureSuccessStatusCode();
            return responseText;
        }
    }
}