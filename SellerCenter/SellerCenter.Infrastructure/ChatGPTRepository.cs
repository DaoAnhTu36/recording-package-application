using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http.Headers;
using System.Text;

namespace SellerCenter.Infrastructure
{
    public class ChatGPTRepository
    {
        private readonly string _apiKey;
        private readonly HttpClient _httpClient;

        public ChatGPTRepository(string apiKey)
        {
            _apiKey = apiKey;
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", _apiKey);
        }

        public async Task<string> AskAsync(string message)
        {
            var body = new
            {
                model = "gpt-5.4",
                input = message
            };

            var json = JsonConvert.SerializeObject(body);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(
                "https://api.openai.com/v1/responses",
                content
            );

            var result = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
                throw new Exception(result);

            var obj = JObject.Parse(result);

            return obj["output"]?[0]?["content"]?[0]?["text"]?.ToString()
                   ?? "Không có phản hồi.";
        }
    }
}