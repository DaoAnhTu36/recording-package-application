using SellerCenter.Infrastructure.Models;
using SellerCenter.Service;

namespace SellerCenter.Forms
{
    public partial class frmPostManager : Form
    {
        private readonly PostContentService? _postContentService;
        private int _idEditing = 0;
        private PostContentModel? _postContentModel = new();

        public frmPostManager()
        {
            InitializeComponent();
            _postContentService = new PostContentService();
        }

        private void MappingData()
        {
            id.DataPropertyName = "id";
            product_code.DataPropertyName = "product_code";
            title.DataPropertyName = "title";
            content.DataPropertyName = "content";
            hook.DataPropertyName = "hook";
            image_url_1.DataPropertyName = "image_url_1";
            image_url_2.DataPropertyName = "image_url_2";
            image_url_3.DataPropertyName = "image_url_3";
            image_url_4.DataPropertyName = "image_url_4";
            image_url_5.DataPropertyName = "image_url_5";
            video_url.DataPropertyName = "video_url";
            hashtag.DataPropertyName = "hashtag";
            created_at.DataPropertyName = "created_at";
            updated_at.DataPropertyName = "updated_at";
        }

        private void AddEditButtonColumn()
        {
            if (dataGridViewPostContent.Columns["btnDelete"] == null)
            {
                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn
                {
                    Name = "btnDelete",
                    HeaderText = string.Empty,
                    Text = "Xóa",
                    UseColumnTextForButtonValue = true,
                };
                dataGridViewPostContent.Columns.Add(btnDelete);
            }
            if (dataGridViewPostContent.Columns["btnEdit"] == null)
            {
                DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn
                {
                    Name = "btnEdit",
                    HeaderText = string.Empty,
                    Text = "Chỉnh sửa",
                    UseColumnTextForButtonValue = true,
                };
                dataGridViewPostContent.Columns.Add(btnEdit);
            }
            if (dataGridViewPostContent.Columns["btnPost"] == null)
            {
                DataGridViewButtonColumn btnPost = new DataGridViewButtonColumn
                {
                    Name = "btnPost",
                    HeaderText = string.Empty,
                    Text = "Đăng bài",
                    UseColumnTextForButtonValue = true,
                };
                dataGridViewPostContent.Columns.Add(btnPost);
            }
        }

        private void dataGridViewPostContent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int _idEditing = Convert.ToInt32(
                dataGridViewPostContent.Rows[e.RowIndex].Cells["id"].Value
            );
            if (dataGridViewPostContent.Columns[e.ColumnIndex].Name == "btnDelete")
            {
                var confirm = MessageBox.Show("Bạn có chắc muốn xóa không?", "Confirm", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    _postContentService?.Delete(_idEditing);
                    dataGridViewPostContent.Rows.RemoveAt(e.RowIndex);
                }
            }
            else if (dataGridViewPostContent.Columns[e.ColumnIndex].Name == "btnEdit")
            {
                ProcessBtnEdit(_idEditing);
            }
            else if (dataGridViewPostContent.Columns[e.ColumnIndex].Name == "btnPost")
            {
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var keyword = txtKeyword.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                GetData();
                return;
            }
            var dataSearch = _postContentService?.Search(keyword);
            MappingData();
            dataGridViewPostContent.DataSource = dataSearch;
        }

        private void GetData()
        {
            var products = _postContentService?.GetAll();
            if (products == null || products.Rows.Count == 0)
            {
                dataGridViewPostContent.DataSource = null;
                return;
            }
            MappingData();
            dataGridViewPostContent.DataSource = products;
            AddEditButtonColumn();
        }

        private void frmPostManager_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void ProcessBtnEdit(int id)
        {
            var postContent = _postContentService?.GetById(id);
            _postContentModel = postContent;
            txtTitle.Text = postContent?.Title;
            txtContent.Text = postContent?.Content;
            txtHook.Text = postContent?.Hook;
            panel1.Visible = true;
            btnCancel.Visible = true;
            btnSave.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _postContentModel.Content = txtContent.Text.Trim();
            _postContentModel.Title = txtTitle.Text.Trim();
            _postContentModel.Hook = txtHook.Text.Trim();
            _postContentService?.Update(_postContentModel);
            panel1.Visible = false;
            btnCancel.Visible = false;
            btnSave.Visible = false;
            GetData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            btnCancel.Visible = false;
            btnSave.Visible = false;
        }
    }
}