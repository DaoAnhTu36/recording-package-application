using SellerCenter.Helper;
using SellerCenter.Helpers;
using SellerCenter.Infrastructure.Models;
using SellerCenter.Service;

namespace SellerCenter.Forms
{
    public partial class frmPostManager : BaseForm
    {
        private readonly PostContentService? _postContentService;
        private int _idEditing = 0;
        private PostContentModel? _postContentModel = new();
        private readonly FacebookService _facebookService;
        private string? videoUrl;

        public frmPostManager()
        {
            InitializeComponent();
            _postContentService = new PostContentService();
            _facebookService = new FacebookService();
        }

        private void MappingData()
        {
            id.DataPropertyName = "id";
            product_code.DataPropertyName = "product_code";
            title.DataPropertyName = "title";
            content.DataPropertyName = "content";
            hook.DataPropertyName = "hook";
            //image_url_1.DataPropertyName = "image_url_1";
            //image_url_2.DataPropertyName = "image_url_2";
            //image_url_3.DataPropertyName = "image_url_3";
            //image_url_4.DataPropertyName = "image_url_4";
            //image_url_5.DataPropertyName = "image_url_5";
            //video_url.DataPropertyName = "video_url";
            hashtag.DataPropertyName = "hashtag";
            created_at.DataPropertyName = "created_at";
            updated_at.DataPropertyName = "updated_at";
        }

        private void GetData()
        {
            var products = _postContentService?.GetAll();
            txtKeyword.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtKeyword.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtKeyword.AutoCompleteCustomSource =
                DataHelper.ToAutoCompleteSource(products!, "product_code");
            if (products == null || products.Rows.Count == 0)
            {
                dataGridViewPostContent.DataSource = null;
                return;
            }
            MappingData();
            dataGridViewPostContent.DataSource = products;
            //AddEditButtonColumn();
        }

        private void frmPostManager_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _postContentModel!.Content = txtContent.Text.Trim();
            _postContentModel.Title = txtTitle.Text.Trim();
            _postContentModel.Hook = txtHook.Text.Trim();
            _postContentModel.Hashtag = txtHashtag.Text.Trim();
            _postContentService?.Update(_postContentModel);
            btnCancel.Visible = false;
            btnSave.Visible = false;
            GetData();
            ResetForm();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnCancel.Visible = false;
            btnSave.Visible = false;
            ResetForm();
        }

        private void ResetForm()
        {
            txtContent.Text = string.Empty;
            txtHook.Text = string.Empty;
            txtKeyword.Text = string.Empty;
            txtTitle.Text = string.Empty;
            txtHashtag.Text = string.Empty;
        }

        private void txtKeyword_TextChanged(object sender, EventArgs e)
        {
            //var keyword = txtKeyword.Text.Trim();
            //if (string.IsNullOrEmpty(keyword))
            //{
            //    GetData();
            //    return;
            //}
            //var dataSearch = _postContentService?.Search(keyword);
            //MappingData();
            //dataGridViewPostContent.DataSource = dataSearch;
        }

        private void txtKeyword_Leave(object sender, EventArgs e)
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

        private void dataGridViewPostContent_Click(object sender, EventArgs e)
        {
            var row = dataGridViewPostContent.CurrentRow;

            if (row != null)
            {
                _idEditing = Convert.ToInt32(row.Cells["id"].Value);
                var postContent = _postContentService?.GetById(_idEditing);
                _postContentModel = postContent;
                txtTitle.Text = postContent?.Title;
                txtHook.Text = postContent?.Hook;
                txtContent.Text = postContent?.Content;
                txtHashtag.Text = postContent?.Hashtag;
                videoPreviewControl1.PreviewVideo(postContent?.VideoUrl!);
                videoUrl = postContent?.VideoUrl;
                btnCancel.Visible = true;
                btnSave.Visible = true;
            }
        }

        private async void btnPost_Click(object sender, EventArgs e)
        {
            var pageId = SessionManager.FacebookPageId;
            var pageToken = SessionManager.FacebookPageToken;
            if (string.IsNullOrEmpty(pageId) || string.IsNullOrEmpty(pageToken))
            {
                if (MessageBox.Show("Bạn có muốn đăng nhập Facebook ngay bây giờ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    {
                        var frmLoginFacebook = new frmFacebook();
                        frmLoginFacebook.ShowDialog();
                    }
                    return;
                }
            }

            if (string.IsNullOrEmpty(txtTitle.Text) || string.IsNullOrEmpty(txtContent.Text) || string.IsNullOrEmpty(txtHook.Text) || string.IsNullOrEmpty(txtHashtag.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin trước khi đăng bài.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            btnPost.Enabled = false;
            lblPostStatus.Visible = true;
            lblPostStatus.Text = "Đang đăng bài...";
            var message = txtTitle.Text;
            message += "\n" + txtHook.Text;
            message += "\n" + txtContent.Text;
            message += "\n" + txtHashtag.Text;
            var postResult = await _facebookService.PostFacebookAsync(pageId!, pageToken!, message);
            lblPostStatus.Visible = false;
            btnPost.Enabled = true;
            MessageBox.Show("Đăng bài thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}