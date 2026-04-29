using SellerCenter.Helpers;
using SellerCenter.Infrastructure.Models;
using SellerCenter.Service;

namespace SellerCenter.Forms
{
    public partial class frmEmployeeManager : Form
    {
        private readonly EmployeeService _employeeService;
        private readonly string[] _lstRole = new string[] { "ADMIN", "EMPLOYEE", "STAFF" };

        public frmEmployeeManager()
        {
            InitializeComponent();
            _employeeService = new EmployeeService();
        }

        private void frmEmployeeManager_Load(object sender, EventArgs e)
        {
            LayoutHelper.EqualRows(formInfo, 7);
            UIHelper.ApplyAll(this);
            cbbRole.Items.AddRange(_lstRole);
            initDataOnLoad();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var role = cbbRole.SelectedItem as string;
            var username = txtUsername.Text;
            var password = txtPassword.Text;
            var email = txtEmail.Text;
            var phone = txtPhone.Text;
            var fullname = txtFullName.Text;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(role) || string.IsNullOrEmpty(fullname))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }
            var employee = new EmployeeModel
            {
                Username = username,
                PasswordHash = password,
                Email = email,
                Phone = phone,
                Role = role,
                FullName = fullname,
            };
            var employeeId = _employeeService.Create(employee);
            if (employeeId > 0)
            {
                initDataOnLoad();
                resetForm();
            }
            else
            {
                MessageBox.Show("Tạo nhân viên thất bại.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
        }

        private void resetForm()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtFullName.Text = "";
            cbbRole.SelectedIndex = -1;
        }

        private void initDataOnLoad()
        {
            var employees = _employeeService.GetAll();
            dataGridView1.DataSource = employees;
            MappingData();
        }

        private void MappingData()
        {
            id.DataPropertyName = "Id";
            username.DataPropertyName = "Username";
            full_name.DataPropertyName = "FullName";
            Email.DataPropertyName = "Email";
            phone.DataPropertyName = "Phone";
            role.DataPropertyName = "Role";
            is_active.DataPropertyName = "IsActive";
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }
    }
}