using SellerCenter.Helper;
using SellerCenter.Infrastructure.Models;
using System.Text.Json;

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
            {
                var error = JsonSerializer.Deserialize<FacebookErrorResponse>(result);

                if (error?.error?.code == 190)
                {
                    SessionManager.ClearFacebookSession();
                    throw new Exception("Token Facebook đã hết hạn. Vui lòng lấy lại token.");
                }

                throw new Exception(error?.error?.message ?? "Lỗi không xác định");
            }

            return result;
        }

        public async Task<string> PostVideoToFacebookAsync(string pageId, string pageToken, string videoPath, string description)
        {
            using var client = new HttpClient();

            var url = $"https://graph.facebook.com/v25.0/{pageId}/videos";

            using var form = new MultipartFormDataContent();

            form.Add(new StringContent(pageToken), "access_token");
            form.Add(new StringContent(description), "description");

            var videoBytes = await File.ReadAllBytesAsync(videoPath);
            var videoContent = new ByteArrayContent(videoBytes);
            videoContent.Headers.ContentType =
                new System.Net.Http.Headers.MediaTypeHeaderValue("video/mp4");

            form.Add(videoContent, "source", Path.GetFileName(videoPath));

            var response = await client.PostAsync(url, form);
            var result = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
                throw new Exception(result);

            return result;
        }
    }
}