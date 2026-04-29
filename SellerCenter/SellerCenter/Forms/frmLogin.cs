using Microsoft.VisualBasic.ApplicationServices;
using OpenCvSharp;
using SellerCenter.Helper;
using SellerCenter.Helpers;
using SellerCenter.Service;
using ZXing.Aztec.Internal;

namespace SellerCenter.Forms
{
    public partial class frmLogin : BaseForm
    {
        private readonly EmployeeService _employeeService;

        public frmLogin()
        {
            InitializeComponent();
            _employeeService = new EmployeeService();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
            var username = txtUsername.Text.Trim();
            var password = txtPassword.Text.Trim();
            var user = _employeeService.Login(username, password);
            if (user != null)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại. Vui lòng kiểm tra lại tên đăng nhập và mật khẩu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnLogin.Enabled = true;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Text = "admin";
            txtPassword.Text = "123123";
        }
    }
}