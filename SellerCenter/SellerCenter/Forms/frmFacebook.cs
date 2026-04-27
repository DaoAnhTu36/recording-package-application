using Microsoft.Web.WebView2.Core;
using Newtonsoft.Json.Linq;
using System.Web;

namespace SellerCenter.Forms
{
    public partial class frmFacebook : Form
    {
        private readonly string redirectUri = "https://localhost/";
        private readonly string graphVersion = "v25.0";

        public frmFacebook()
        {
            InitializeComponent();
            InitWebView();
        }

        private async void InitWebView()
        {
            await webView21.EnsureCoreWebView2Async();
            webView21.CoreWebView2.NavigationStarting += WebView_NavigationStarting!;
        }

        private async void WebView_NavigationStarting(object sender, CoreWebView2NavigationStartingEventArgs e)
        {
            string url = e.Uri;

            if (url.StartsWith(redirectUri) && url.Contains("access_token"))
            {
                e.Cancel = true;

                string userToken = ExtractTokenFromUrl(url);
                txtUserToken.Text = userToken;

                await GetPageTokenAsync(userToken);

                MessageBox.Show("Lấy token thành công!");
            }
        }

        private string ExtractTokenFromUrl(string url)
        {
            var uri = new Uri(url);
            string fragment = uri.Fragment.Replace("#", "");

            var query = HttpUtility.ParseQueryString(fragment);

            return query["access_token"];
        }

        private async Task GetPageTokenAsync(string userToken)
        {
            using var client = new HttpClient();

            string url =
                $"https://graph.facebook.com/{graphVersion}/me/accounts" +
                $"?access_token={HttpUtility.UrlEncode(userToken)}";

            string json = await client.GetStringAsync(url);

            JObject obj = JObject.Parse(json);

            var firstPage = obj["data"]?.FirstOrDefault();

            if (firstPage == null)
            {
                throw new Exception("Không tìm thấy Page. Kiểm tra tài khoản có phải Admin Page không.");
            }

            txtPageId.Text = firstPage["id"]?.ToString();
            txtPageToken.Text = firstPage["access_token"]?.ToString();
        }

        private void frmFacebook_Load(object sender, EventArgs e)
        {
        }

        private async void btnPostFacebook_Click(object sender, EventArgs e)
        {
            try
            {
                btnPostFacebook.Enabled = false;
                btnPostFacebook.Text = "Đang đăng...";

                string pageId = txtPageId.Text.Trim();
                string pageToken = txtPageToken.Text.Trim();
                string content = txtContent.Text.Trim();

                string result = await PostFacebookAsync(pageId, pageToken, content);

                MessageBox.Show("Đăng Facebook thành công!\n" + result);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                btnPostFacebook.Enabled = true;
                btnPostFacebook.Text = "Đăng Facebook";
            }
        }

        private async Task<string> PostFacebookAsync(string pageId, string pageToken, string message)
        {
            using var client = new HttpClient();

            string url = $"https://graph.facebook.com/{graphVersion}/{pageId}/feed";

            var data = new Dictionary<string, string>
            {
                { "message", message },
                { "access_token", pageToken }
            };

            var response = await client.PostAsync(url, new FormUrlEncodedContent(data));
            string result = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
                throw new Exception(result);

            return result;
        }

        private void btnGetToken_Click(object sender, EventArgs e)
        {
            string appId = txtAppId.Text.Trim();

            string scope = "pages_show_list,pages_read_engagement,pages_manage_posts";

            string loginUrl =
                $"https://www.facebook.com/{graphVersion}/dialog/oauth" +
                $"?client_id={appId}" +
                $"&redirect_uri={HttpUtility.UrlEncode(redirectUri)}" +
                $"&scope={HttpUtility.UrlEncode(scope)}" +
                $"&response_type=token";

            webView21.Source = new Uri(loginUrl);
        }
    }
}