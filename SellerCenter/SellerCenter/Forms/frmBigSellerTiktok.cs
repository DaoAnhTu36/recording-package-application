using Microsoft.Web.WebView2.Core;

namespace SellerCenter.Forms
{
    public partial class frmBigSellerTiktok : Form
    {
        public frmBigSellerTiktok()
        {
            InitializeComponent();
        }

        private async Task InitWebViewAsync()
        {
            string path = Path.Combine(Application.StartupPath, "WebViewProfile", "TikTok");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            var env = await CoreWebView2Environment.CreateAsync(null, path);
            await webViewBigSellerTiktok.EnsureCoreWebView2Async(env);
            webViewBigSellerTiktok.Source = new Uri("https://www.bigseller.com/web/order/index.htm?status=new");
        }

        private async void frmBigSellerTiktok_Load(object sender, EventArgs e)
        {
            await InitWebViewAsync();
        }
    }
}