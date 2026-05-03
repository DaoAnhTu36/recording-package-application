using Org.BouncyCastle.Asn1.Cmp;
using SellerCenter.Helpers;
using SellerCenter.Infrastructure.Models;
using SellerCenter.Service;
using SellerCenter.Service.Implementation;

namespace SellerCenter.Forms
{
    public partial class frmPermission : BaseForm
    {
        private readonly IPermissionService _permissionService;
        private long _idEditing;

        public frmPermission()
        {
            InitializeComponent();
            _permissionService = ServiceLocator.Get<IPermissionService>();
        }

        private void frmPermission_Load(object sender, EventArgs e)
        {
            GetAll();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var permission = new PermissionModel
            {
                PermissionCode = txtPermissionCode.Text?.ToUpper(),
                PermissionName = txtPermissionName.Text,
                Description = txtDescription.Text
            };
            if (_idEditing > 0)
            {
                permission.Id = _idEditing;
                _permissionService.Update(permission);
            }
            else
                _permissionService.Create(permission);
            ResetForm();
            GetAll();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void GetAll()
        {
            var data = _permissionService.GetAll();
            dataGridView1.DataSource = data;
        }

        private void ResetForm()
        {
            FormHelper.ClearForm(this);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _idEditing = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
            var permission = _permissionService.GetById(_idEditing);
            txtPermissionCode.Text = permission.PermissionCode;
            txtPermissionName.Text = permission.PermissionName;
            txtDescription.Text = permission.Description;
        }
    }
}