namespace SellerCenter.UserControls
{
    public partial class SocialMediaPlatformControl : UserControl
    {
        private List<string>? _lstSocial;

        public SocialMediaPlatformControl()
        {
            InitializeComponent();
            GeneratePlatformSocial();
        }

        private void GeneratePlatformSocial()
        {
            if (_lstSocial == null || _lstSocial.Count == 0)
            {
                _lstSocial = new List<string> { "Shopee", "TikTok", "Facebook" };
            }

            foreach (var item in _lstSocial)
            {
                var rb = new RadioButton
                {
                    Text = item,
                    AutoSize = true
                };

                flowSocialMediaPlatformPanel.Controls.Add(rb);
            }
        }

        public string GetSelectedPlatform()
        {
            foreach (var control in flowSocialMediaPlatformPanel.Controls)
            {
                if (control is RadioButton rb && rb.Checked)
                {
                    return rb.Text;
                }
            }
            return string.Empty;
        }

        public void SetSelectedPlatform(string platform)
        {
            foreach (var control in flowSocialMediaPlatformPanel.Controls)
            {
                if (control is RadioButton rb && rb.Text.Equals(platform, StringComparison.OrdinalIgnoreCase))
                {
                    rb.Checked = true;
                    break;
                }
            }
        }

        public void ClearSelection()
        {
            foreach (var control in flowSocialMediaPlatformPanel.Controls)
            {
                if (control is RadioButton rb)
                {
                    rb.Checked = false;
                }
            }
        }
    }
}