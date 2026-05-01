using SellerCenter.Helpers;
using SellerCenter.Infrastructure.Models;
using SellerCenter.Service;

namespace SellerCenter.Forms
{
    public partial class frmTemplatePrompt : BaseForm
    {
        private readonly PromptTemplateService _promptTemplateService;
        private long _idEditing = 0;
        public PromptTemplateModel? promptTemplateModel;

        public frmTemplatePrompt()
        {
            InitializeComponent();
            _promptTemplateService = new PromptTemplateService();
        }

        private void frmTemplatePrompt_Load(object sender, EventArgs e)
        {
            FillDataToGridView();
        }

        private void FillDataToGridView()
        {
            var lstTemplate = _promptTemplateService.GetAll();
            dataGridViewListTemplate.DataSource = null;
            dataGridViewListTemplate.DataSource = lstTemplate;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var platform = socialMediaPlatformControl1.GetSelectedPlatform();
            var articleType = articleTypeControl1.GetSelectedArticleType();
            var content = txtTemplateDesc.Text;
            var title = $"{platform} - {articleType}";
            if (string.IsNullOrEmpty(content) || string.IsNullOrEmpty(platform) || string.IsNullOrEmpty(articleType))
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin.");
                return;
            }
            var template = new PromptTemplateModel
            {
                Platform = platform,
                IsActive = true,
                PostType = articleType,
                TemplateContent = content,
                title = title,
            };
            if (promptTemplateModel != null)
            {
                promptTemplateModel.Platform = platform;
                promptTemplateModel.PostType = articleType;
                promptTemplateModel.TemplateContent = content;
                promptTemplateModel.title = title;
                _promptTemplateService.Update(promptTemplateModel);
            }
            else
            {
                var idTemplate = _promptTemplateService.Insert(template);
            }
            ResetForm();
            FillDataToGridView();
        }

        private void ResetForm()
        {
            socialMediaPlatformControl1.ClearSelection();
            articleTypeControl1.ClearSelection();
            txtTemplateDesc.Text = string.Empty;
            promptTemplateModel = null;
            FormHelper.ClearForm(this);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void dataGridViewListTemplate_Click(object sender, EventArgs e)
        {
            var row = dataGridViewListTemplate.CurrentRow;

            if (row != null)
            {
                _idEditing = Convert.ToInt32(row.Cells["id"].Value);
                var template = _promptTemplateService.GetById(_idEditing);
                promptTemplateModel = template;
                socialMediaPlatformControl1.SetSelectedPlatform(template?.Platform!);
                articleTypeControl1.SetSelectedArticleType(template?.PostType!);
                txtTemplateDesc.Text = template?.TemplateContent;
            }
        }
    }
}