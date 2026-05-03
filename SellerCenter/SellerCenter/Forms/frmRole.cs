using SellerCenter.Helpers;
using SellerCenter.Infrastructure.Models;
using SellerCenter.Service;

namespace SellerCenter.Forms
{
    public partial class frmRole : BaseForm
    {
        private readonly IRoleService _roleService;
        private long _idEditing;

        public frmRole()
        {
            InitializeComponent();
            _roleService = ServiceLocator.Get<IRoleService>();
        }

        private void frmRole_Load(object sender, EventArgs e)
        {
            GetRoles();
        }

        private void GetRoles()
        {
            var roles = _roleService.GetAll();
            dataGridView1.DataSource = roles;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var role = new RoleModel
            {
                RoleCode = txtRoleCode.Text?.ToUpper(),
                RoleName = txtRoleName.Text,
                Description = txtRoleDescription.Text,
                IsActive = chkStatus.Checked,
            };
            if (_idEditing > 0)
            {
                role.Id = _idEditing;
                role.UpdatedAt = DateTime.Now;
                _roleService.Update(role);
                _idEditing = 0;
            }
            else
            {
                _roleService.Create(role);
            }
            GetRoles();
            ResetForm();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            FormHelper.ClearForm(this);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _idEditing = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
            var role = _roleService.GetById(_idEditing);
            txtRoleCode.Text = role.RoleCode;
            txtRoleName.Text = role.RoleName;
            txtRoleDescription.Text = role.Description;
            chkStatus.Checked = role.IsActive;
        }
    }
}