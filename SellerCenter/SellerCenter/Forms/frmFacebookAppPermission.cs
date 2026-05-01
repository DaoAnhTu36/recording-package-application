using SellerCenter.Helpers;
using SellerCenter.Service;

namespace SellerCenter.Forms
{
    public partial class frmFacebookAppPermission : BaseForm
    {
        private readonly FacebookAppsService _facebookAppsService;
        private readonly FacebookAppPermissionsService _facebookAppPermissionsService;

        public frmFacebookAppPermission()
        {
            InitializeComponent();
            _facebookAppsService = new FacebookAppsService();
            _facebookAppPermissionsService = new FacebookAppPermissionsService();
        }

        private void frmFacebookAppPermission_Load(object sender, EventArgs e)
        {
            LayoutHelper.EqualRows(tableLayoutPanel1, 3);
            var lstApp = _facebookAppsService.GetAll();
            cbbAppId.DisplayMember = "AppName";
            cbbAppId.ValueMember = "Id";
            var lstPermission = _facebookAppPermissionsService.GetWithAppName();
            dataGridView1.DataSource = lstPermission;
            cbbAppId.DataSource = lstApp;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var facebookAppId = (long)cbbAppId?.SelectedValue!;
            var permissionName = txtPermissionName.Text.Trim();
            var result = _facebookAppPermissionsService.Create(facebookAppId, permissionName);
            if (result > 0)
            {
                var lstPermission = _facebookAppPermissionsService.GetWithAppName();
                dataGridView1.DataSource = lstPermission;
                resetForm();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var facebookAppId = (long)cbbAppId?.SelectedValue!;
            var permissionName = txtPermissionName.Text.Trim();
            var result = _facebookAppPermissionsService.Create(facebookAppId, permissionName);
            if (result > 0)
            {
                var lstPermission = _facebookAppPermissionsService.GetAll();
                dataGridView1.DataSource = lstPermission;
                resetForm();
            }
        }

        private void resetForm()
        {
            cbbAppId.SelectedIndex = -1;
            txtPermissionName.Text = string.Empty;
        }
    }
}