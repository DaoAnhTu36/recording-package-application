using Microsoft.Extensions.Configuration;
using SellerCenter.Infrastructure;

namespace SellerCenter.Forms
{
    public partial class frmCreateNewPost : Form
    {
        private ChatGPTRepository? _chatGpt;

        public frmCreateNewPost()
        {
            InitializeComponent();
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    btnSubmit.Enabled = false;
            //    btnSubmit.Text = "Đang xử lý...";

            //    string question = txtRequestAI.Text.Trim();

            //    if (string.IsNullOrEmpty(question))
            //    {
            //        txtResponseAI.Text = "Vui lòng nhập nội dung.";
            //        return;
            //    }
            //    if (_chatGpt == null)
            //    {
            //        txtResponseAI.Text = "ChatGPT chưa được khởi tạo.";
            //        return;
            //    }
            //    else
            //    {
            //        var answer = await _chatGpt.AskAsync(question);

            //        txtResponseAI.Text = answer;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Lỗi");
            //}
            //finally
            //{
            //    btnSubmit.Enabled = true;
            //    btnSubmit.Text = "Tạo mới";
            //}
        }

        private void frmCreateNewPost_Load(object sender, EventArgs e)
        {
        }

        private void ConnectToChatGPT()
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
            var apiKey = config["OpenAI:ApiKey"];
            _chatGpt = new ChatGPTRepository(apiKey!);
        }
    }
}