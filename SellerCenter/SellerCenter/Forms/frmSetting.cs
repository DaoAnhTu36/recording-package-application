using SellerCenter.Helper;
using SellerCenter.Helpers;
using SellerCenter.Service;

namespace SellerCenter.Forms
{
    public partial class frmSetting : Form
    {
        private readonly EmployeeService _employeeService;

        public frmSetting()
        {
            InitializeComponent();
            _employeeService = new EmployeeService();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát khỏi hệ thống?",
                "Xác nhận đăng xuất",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
                return;

            LogoutAndExit();
        }

        private void btnClearCache_Click(object sender, EventArgs e)
        {
        }

        private void LogoutAndExit()
        {
            try
            {
                _employeeService.Logout();
                SessionManager.ClearSession();
            }
            catch
            {
                // tránh crash nếu DB lỗi
            }
            this.Hide();

            using (var loginForm = new frmLogin())
            {
                var result = loginForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    this.Show();
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void frmSetting_Load(object sender, EventArgs e)
        {
            UIHelper.ApplyAll(this);
        }
    }
}