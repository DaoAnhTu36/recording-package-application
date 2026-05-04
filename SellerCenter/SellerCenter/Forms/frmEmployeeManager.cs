using Org.BouncyCastle.Asn1.Cmp;
using SellerCenter.Helpers;
using SellerCenter.Infrastructure.Models;
using SellerCenter.Service;
using SellerCenter.Service.Implementation;
using System.Data;

namespace SellerCenter.Forms
{
    public partial class frmEmployeeManager : BaseForm
    {
        private readonly IEmployeeService _employeeService;
        private readonly IRoleService _roleService;
        private long _idEditing;

        public frmEmployeeManager()
        {
            InitializeComponent();
            _employeeService = ServiceLocator.Get<IEmployeeService>();
            _roleService = ServiceLocator.Get<IRoleService>();
        }

        private void frmEmployeeManager_Load(object sender, EventArgs e)
        {
            LayoutHelper.EqualRows(formInfo, 7);
            initDataOnLoad();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var role = cbbRole.SelectedValue?.ToString();
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
                RoleId = Convert.ToInt64(role),
                FullName = fullname,
            };
            var employeeId = _employeeService.Create(employee);
            MessageBox.Show("Tạo mới thành công");
            initDataOnLoad();
            resetForm();
        }

        private void resetForm()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtFullName.Text = "";
            cbbRole.SelectedIndex = -1;
            _idEditing = 0;
            txtEmail.Enabled = true;
            txtFullName.Enabled = true;
            txtPassword.Enabled = true;
            txtPhone.Enabled = true;
            txtUsername.Enabled = true;
            btnUpdate.Visible = false;
            btnSave.Visible = true;
        }

        private void initDataOnLoad()
        {
            var employees = _employeeService.GetAll();
            dataGridView1.DataSource = employees;

            cbbRole.DisplayMember = "RoleName";
            cbbRole.ValueMember = "Id";
            cbbRole.DataSource = _roleService.GetAllList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _idEditing = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
            var employee = _employeeService.GetById(_idEditing);
            cbbRole.SelectedValue = employee.RoleId;
            btnUpdate.Visible = true;
            btnSave.Visible = false;
            txtEmail.Enabled = false;
            txtFullName.Enabled = false;
            txtPassword.Enabled = false;
            txtPhone.Enabled = false;
            txtUsername.Enabled = false;
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            var role = cbbRole.SelectedValue?.ToString();
            if (string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }
            if (_idEditing > 0)
            {
                await _employeeService.UpdateRole(_idEditing, Convert.ToInt64(role));
                initDataOnLoad();
                resetForm();
                MessageBox.Show("Cập nhật thành công");
            }
        }
    }
}