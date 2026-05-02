using SellerCenter.Helper;
using SellerCenter.Helpers;
using SellerCenter.Infrastructure.Models;
using SellerCenter.Service;

namespace SellerCenter.Forms
{
    public partial class frmPostManager : BaseForm
    {
        private readonly IPostContentService _postContentService;
        private int _idEditing = 0;
        private PostContentModel? _postContentModel = new();
        private readonly IFacebookService _facebookService;
        private string? videoUrl;

        public frmPostManager()
        {
            InitializeComponent();
            _postContentService = ServiceLocator.Get<IPostContentService>();
            _facebookService = ServiceLocator.Get<IFacebookService>();
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
            dataGridViewPostContent.DataSource = products;
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
            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            btnPost.Enabled = false;
            GetData();
            ResetForm();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            btnPost.Enabled = false;
            ResetForm();
        }

        private void ResetForm()
        {
            FormHelper.ClearForm(this);
            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            btnPost.Enabled = false;
        }

        private void txtKeyword_TextChanged(object sender, EventArgs e)
        {
            var keyword = txtKeyword.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                GetData();
                return;
            }
            var dataSearch = _postContentService?.Search(keyword);
            dataGridViewPostContent.DataSource = dataSearch;
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
                btnCancel.Enabled = true;
                btnSave.Enabled = true;
                btnPost.Enabled = true;
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
            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            btnPost.Enabled = false;
            lblPostStatus.Visible = true;
            lblPostStatus.Text = "Đang đăng bài...";
            var message = txtTitle.Text;
            message += "\n" + txtHook.Text;
            message += "\n" + txtContent.Text;
            message += "\n" + txtHashtag.Text;

            try
            {
                //var postResult = await _facebookService.PostFacebookAsync(pageId!, pageToken!, message);
                if (string.IsNullOrEmpty(videoUrl))
                {
                    await _facebookService.PostFacebookAsync(pageId!, pageToken!, message);
                }
                else
                {
                    await _facebookService.PostVideoToFacebookAsync(pageId!, pageToken!, videoUrl!, message);
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                MessageBox.Show("Đăng bài thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            lblPostStatus.Visible = false;
            ResetForm();
        }
    }
}