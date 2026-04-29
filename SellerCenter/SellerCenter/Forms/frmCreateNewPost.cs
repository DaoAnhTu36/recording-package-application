using Newtonsoft.Json;
using SellerCenter.Commons;
using SellerCenter.Helper;
using SellerCenter.Helpers;
using SellerCenter.Infrastructure;
using SellerCenter.Infrastructure.Models;
using SellerCenter.Models;
using SellerCenter.Service;
using System.Data;

namespace SellerCenter.Forms
{
    public partial class frmCreateNewPost : Form
    {
        private ChatGPTRepository? _chatGpt;
        private PromptTemplateService? _promptTemplateService;
        private ProductService? _productService;
        private List<string>? _lstImageUrls;
        private string? _videoUrl;

        public frmCreateNewPost()
        {
            InitializeComponent();
            _promptTemplateService = new PromptTemplateService();
            _productService = new ProductService();
        }

        private void frmCreateNewPost_Load(object sender, EventArgs e)
        {
            UIHelper.ApplyAll(this);
            LayoutHelper.EqualRows(tableLayoutPanel2, 5);
            GetListTemplates();
            GetAllProducts();
            ConnectToChatGPT();
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

        private void ConnectToChatGPT()
        {
            //var config = new ConfigurationBuilder()
            //    .AddJsonFile("appsettings.json")
            //    .Build();
            //var apiKey = config["OpenAI:ApiKey"];
            var openAiConfig = AppConfig.Get<OpenAIConfig>("OpenAI");
            _chatGpt = new ChatGPTRepository(openAiConfig.ApiKey!);
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
                var answer = await _chatGpt?.AskAsync(question, [])!;
                txtResponseChatGPT.Text = Utilities.FormatJson(answer);
                ChatGPTModel result = JsonConvert.DeserializeObject<ChatGPTModel>(answer)!;
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
            }
        }

        private void InsertResultToDatabase(ChatGPTModel result)
        {
            foreach (var item in result.Data!)
            {
                var post = new PostContentModel
                {
                    ProductCode = txtProductCode.Text.Trim(),
                    Title = item.Title,
                    Content = item.Content,
                    Hook = item.Hook,
                    ImageUrl1 = item.Image_Url_1,
                    ImageUrl2 = item.Image_Url_2,
                    ImageUrl3 = item.Image_Url_3,
                    ImageUrl4 = item.Image_Url_4,
                    ImageUrl5 = item.Image_Url_5,
                    VideoUrl = item.Video_Url,
                    Hashtag = item.Hashtag
                };
                var postContentService = new PostContentService();
                postContentService?.Insert(post);
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
                var productInfo = _productService?.GetByProductCode(txtProductCode.Text.Trim());
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
    }
}