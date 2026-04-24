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
    }
}