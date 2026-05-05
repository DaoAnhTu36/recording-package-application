using Microsoft.Web.WebView2.Core;

namespace SellerCenter.Forms
{
    public partial class frmBigSellerShopee : Form
    {
        public frmBigSellerShopee()
        {
            InitializeComponent();
        }

        private async void frmBigSeller_Load(object sender, EventArgs e)
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "WebViewProfile", "Shopee");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            var env = await CoreWebView2Environment.CreateAsync(null, path);
            await webViewBigSellerShopee.EnsureCoreWebView2Async(env);
            webViewBigSellerShopee.Source = new Uri("https://www.bigseller.com/web/order/index.htm?status=new");
        }
    }
}