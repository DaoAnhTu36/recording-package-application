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

        public async Task<string> AskAsync(string message, List<string> imagePaths)
        {
            var contentList = new List<object>
            {
                new
                {
                    type = "input_text",
                    text = message
                }
            };

            foreach (var path in imagePaths)
            {
                if (!File.Exists(path))
                    continue;

                string ext = Path.GetExtension(path).ToLower();
                string mimeType = ext switch
                {
                    ".jpg" or ".jpeg" => "image/jpeg",
                    ".png" => "image/png",
                    ".webp" => "image/webp",
                    _ => "image/png"
                };

                string base64 = Convert.ToBase64String(File.ReadAllBytes(path));

                contentList.Add(new
                {
                    type = "input_image",
                    image_url = $"data:{mimeType};base64,{base64}"
                });
            }
            var requestBody = new
            {
                model = "gpt-5.4",
                input = new object[]
                {
                    new
                    {
                        type = "message",
                        role = "user",
                        content = contentList
                    }
                }
            };

            //var json = JsonConvert.SerializeObject(body);
            var json = JsonConvert.SerializeObject(requestBody);
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