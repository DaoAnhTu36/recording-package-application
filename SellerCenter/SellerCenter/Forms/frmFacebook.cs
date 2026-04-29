using Microsoft.Web.WebView2.Core;
using Newtonsoft.Json.Linq;
using SellerCenter.Commons;
using SellerCenter.Helper;
using SellerCenter.Models;
using System.Web;

namespace SellerCenter.Forms
{
    public partial class frmFacebook : BaseForm
    {
        private string? redirectUri;
        private string? graphVersion;
        private readonly FacebookConfig facebookConfig = AppConfig.Get<FacebookConfig>("Facebook");

        public frmFacebook()
        {
            InitializeComponent();
            InitWebView();
            redirectUri = facebookConfig.RedirectUri;
            graphVersion = facebookConfig.GraphVersion;
        }

        private async void InitWebView()
        {
            await webView21.EnsureCoreWebView2Async();
            webView21.CoreWebView2.NavigationStarting += WebView_NavigationStarting!;
        }

        private async void WebView_NavigationStarting(object sender, CoreWebView2NavigationStartingEventArgs e)
        {
            string url = e.Uri;

            if (url.StartsWith(redirectUri!) && url.Contains("access_token"))
            {
                e.Cancel = true;
                string userToken = ExtractTokenFromUrl(url);
                SessionManager.SetFacebookUserToken(userToken);
                await GetPageTokenAsync(userToken);
                this.Dispose();
            }
        }

        private string ExtractTokenFromUrl(string url)
        {
            var uri = new Uri(url);
            string fragment = uri.Fragment.Replace("#", "");

            var query = HttpUtility.ParseQueryString(fragment);

            return query["access_token"]!;
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

            SessionManager.SetFacebookPageId(firstPage["id"]?.ToString()!);
            SessionManager.SetFacebookPageToken(firstPage["access_token"]?.ToString()!);
        }

        private void frmFacebook_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SessionManager.FacebookPageToken) && !string.IsNullOrEmpty(SessionManager.FacebookPageId))
            {
                MessageBox.Show("Đã kết nối Facebook thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                return;
            }
            if (!string.IsNullOrEmpty(SessionManager.AppId))
            {
                string scope = "pages_show_list,pages_read_engagement,pages_manage_posts";
                string loginUrl =
                    $"https://www.facebook.com/{graphVersion}/dialog/oauth" +
                    $"?client_id={SessionManager.AppId}" +
                    $"&redirect_uri={HttpUtility.UrlEncode(redirectUri)}" +
                    $"&scope={HttpUtility.UrlEncode(scope)}" +
                    $"&response_type=token";
                webView21.Source = new Uri(loginUrl);
            }
        }
    }
}