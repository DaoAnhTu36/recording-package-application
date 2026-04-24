using SellerCenter.Infrastructure.Models;
using SellerCenter.Service;

namespace SellerCenter.Forms
{
    public partial class frmTemplatePrompt : Form
    {
        private readonly PromptTemplateService _promptTemplateService;
        private bool _isEditting = false;
        private long _idEditing = 0;

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
            id.DataPropertyName = "id";
            platform.DataPropertyName = "platform";
            post_type.DataPropertyName = "post_type";
            template_content.DataPropertyName = "template_content";
            is_active.DataPropertyName = "is_active";
            created_at.DataPropertyName = "created_at";
            updated_at.DataPropertyName = "updated_at";
            title.DataPropertyName = "title";
            dataGridViewListTemplate.DataSource = null;
            dataGridViewListTemplate.DataSource = lstTemplate;
            AddEditButtonColumn();
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
            if (_isEditting)
            {
                template.Id = _idEditing;
                _promptTemplateService.Update(template);
            }
            else
            {
                var idTemplate = _promptTemplateService.Insert(template);
            }
            ResetForm();
            FillDataToGridView();
        }

        private void AddEditButtonColumn()
        {
            if (dataGridViewListTemplate.Columns["btnEdit"] == null)
            {
                DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn
                {
                    Name = "btnEdit",
                    HeaderText = "Chỉnh sửa",
                    Text = "Sửa",
                    UseColumnTextForButtonValue = true,
                    FlatStyle = FlatStyle.Flat,
                };

                dataGridViewListTemplate.Columns.Add(btnEdit);
            }
        }

        private void dataGridViewListTemplate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || _isEditting) return;

            if (dataGridViewListTemplate.Columns[e.ColumnIndex].Name == "btnEdit")
            {
                int id = Convert.ToInt32(
                    dataGridViewListTemplate.Rows[e.RowIndex].Cells["id"].Value
                );
                _idEditing = id;
                _isEditting = true;
                var template = _promptTemplateService.GetById(id);
                socialMediaPlatformControl1.SetSelectedPlatform(template?.Platform!);
                articleTypeControl1.SetSelectedArticleType(template?.PostType!);
                txtTemplateDesc.Text = template?.TemplateContent;
            }
        }

        private void ResetForm()
        {
            socialMediaPlatformControl1.ClearSelection();
            articleTypeControl1.ClearSelection();
            txtTemplateDesc.Text = string.Empty;
            _isEditting = false;
            _idEditing = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}