using Newtonsoft.Json;
using SellerCenter.Helper;
using SellerCenter.Helpers;
using SellerCenter.Infrastructure.Models;
using SellerCenter.Service;
using System.Data;

namespace SellerCenter.Forms
{
    public partial class frmCreateNewPost : BaseForm
    {
        private readonly IPromptTemplateService _promptTemplateService;
        private readonly IProductService _productService;
        private readonly IPostContentService _postContentService;
        private List<string>? _lstImageUrls;
        private string? _videoUrl;
        private string? selectedVideoPath;
        private readonly IChatGPTService _chatGPTService;

        public frmCreateNewPost()
        {
            InitializeComponent();
            _promptTemplateService = ServiceLocator.Get<IPromptTemplateService>();
            _productService = ServiceLocator.Get<IProductService>();
            _chatGPTService = ServiceLocator.Get<IChatGPTService>();
            _postContentService = ServiceLocator.Get<IPostContentService>();
        }

        private void frmCreateNewPost_Load(object sender, EventArgs e)
        {
            GetListTemplates();
            GetAllProducts();
        }

        private void GetListTemplates()
        {
            var listTemplates = _promptTemplateService?.GetAll();
            lstTemplate.DisplayMember = "title";
            lstTemplate.ValueMember = "id";
            lstTemplate.DataSource = listTemplates;
        }

        private void GetAllProducts()
        {
            var listProducts = _productService?.GetAll();
            if (listProducts != null)
            {
                var source = new AutoCompleteStringCollection();
                source.AddRange(
                    listProducts.AsEnumerable()
                             .Select(row => row["product_code"].ToString())
                             .ToArray()!
                );
                txtProductCode.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtProductCode.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtProductCode.AutoCompleteCustomSource = source;
            }
        }

        private void txtProductCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchProduct();
            }
        }

        private void ResetForm()
        {
            txtProductName.Text = "";
            txtProductDesc.Text = "";
        }

        private void txtProductCode_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProductCode.Text))
            {
                ResetForm();
            }
        }

        private async void btnCreatePost_Click(object sender, EventArgs e)
        {
            btnCreatePost.Enabled = false;
            btnCreatePost.Text = "Đang tạo bài đăng...";
            var selectedTemplate = lstTemplate.SelectedValue;
            var productCode = txtProductCode.Text.Trim();
            var productName = txtProductName.Text.Trim();
            var productDesc = txtProductDesc.Text.Trim();
            var quantity = (int)txtQuantitPost.Value;
            var templateInfo = _promptTemplateService?.GetById((long)selectedTemplate!);
            if (templateInfo is null)
            {
                return;
            }
            var content = templateInfo?.TemplateContent?
            .Replace("{{product_name}}", productName)
            .Replace("{{product_desc}}", productDesc)
            .Replace("{{quantity}}", quantity.ToString());
            try
            {
                var question = content?.Trim()!;
                var answer = await _chatGPTService.SendRequest(question, [])!;
                ChatGPTModel result = JsonConvert.DeserializeObject<ChatGPTModel>(answer)!;
                txtResponseChatGPT.Text = answer;
                InsertResultToDatabase(result);
                btnCreatePost.Enabled = true;
                btnCreatePost.Text = "Tạo bài đăng";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
            finally
            {
                btnCreatePost.Enabled = true;
                btnCreatePost.Text = "Tạo bài viết";
            }
        }

        private void InsertResultToDatabase(ChatGPTModel result)
        {
            foreach (var item in result.Data!)
            {
                var post = new PostContentModel
                {
                    ProductCode = txtProductCode.Text.Trim().ToUpper(),
                    Title = item.Title,
                    Content = item.Content,
                    Hook = item.Hook,
                    VideoUrl = selectedVideoPath,
                    Hashtag = item.Hashtag,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                };
                _postContentService.Create(post);
            }
        }

        private void txtProductCode_Leave(object sender, EventArgs e)
        {
            searchProduct();
        }

        private void searchProduct()
        {
            if (!string.IsNullOrEmpty(txtProductCode.Text))
            {
                var productInfo = _productService.GetByProductCode(txtProductCode.Text.Trim());
                if (productInfo != null)
                {
                    txtProductName.Text = productInfo.ProductName ?? "";
                    txtProductDesc.Text = productInfo.Description ?? "";
                    _lstImageUrls = productInfo?.ImageUrl?.Split(CharacterConstants.Separator)?.ToList()!;
                    _videoUrl = productInfo?.VideoUrl ?? "";
                }
                else
                {
                    ResetForm();
                }
            }
        }

        private void btnVideo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn video";
                ofd.Filter = "Video Files|*.mp4;*.avi;*.mov;*.mkv;*.wmv";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedVideoPath = ofd.FileName;
                    videoPreviewControl1.PreviewVideo(selectedVideoPath);
                }
            }
        }
    }
}