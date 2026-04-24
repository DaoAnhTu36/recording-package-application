namespace SellerCenter.UserControls
{
    public partial class ArticleTypeControl : UserControl
    {
        private List<string>? _lstArticleType;

        public ArticleTypeControl()
        {
            InitializeComponent();
            GetListArticleType();
        }

        private void GetListArticleType()
        {
            if (_lstArticleType == null || _lstArticleType.Count == 0)
            {
                _lstArticleType = new List<string> { "Bài viết", "Reel" };
            }

            foreach (var item in _lstArticleType)
            {
                var rb = new RadioButton
                {
                    Text = item,
                    AutoSize = true
                };

                flowArticleTypePanel.Controls.Add(rb);
            }
        }

        public string GetSelectedArticleType()
        {
            foreach (var control in flowArticleTypePanel.Controls)
            {
                if (control is RadioButton rb && rb.Checked)
                {
                    return rb.Text;
                }
            }
            return string.Empty;
        }

        public void SetSelectedArticleType(string articleType)
        {
            foreach (var control in flowArticleTypePanel.Controls)
            {
                if (control is RadioButton rb && rb.Text.Equals(articleType, StringComparison.OrdinalIgnoreCase))
                {
                    rb.Checked = true;
                    break;
                }
            }
        }

        public void ClearSelection()
        {
            foreach (var control in flowArticleTypePanel.Controls)
            {
                if (control is RadioButton rb)
                {
                    rb.Checked = false;
                }
            }
        }
    }
}