using SellerCenter.Helpers;
using SellerCenter.Infrastructure.Models;
using SellerCenter.Service;

namespace SellerCenter.Forms
{
    public partial class frmFacebookAppPermission : BaseForm
    {
        private readonly IFacebookAppService _facebookAppsService;
        private readonly IFacebookAppPermissionsService _facebookAppPermissionsService;

        public frmFacebookAppPermission()
        {
            InitializeComponent();
            _facebookAppsService = ServiceLocator.Get<IFacebookAppService>();
            _facebookAppPermissionsService = ServiceLocator.Get<IFacebookAppPermissionsService>();
        }

        private async void frmFacebookAppPermission_Load(object sender, EventArgs e)
        {
            LayoutHelper.EqualRows(tableLayoutPanel1, 3);
            var lstApp = _facebookAppsService.GetAll();
            cbbAppId.DisplayMember = "AppName";
            cbbAppId.ValueMember = "Id";
            var lstPermission = await _facebookAppPermissionsService.GetWithAppName();
            dataGridView1.DataSource = lstPermission;
            cbbAppId.DataSource = lstApp;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var facebookAppId = (long)cbbAppId?.SelectedValue!;
            var permissionName = txtPermissionName.Text.Trim();
            var result = _facebookAppPermissionsService.Create(new FacebookAppPermissionModel
            {
                FacebookAppId = facebookAppId,
                PermissionName = permissionName,
                CreatedAt = DateTime.Now,
            });
            if (result > 0)
            {
                var lstPermission = await _facebookAppPermissionsService.GetWithAppName();
                dataGridView1.DataSource = lstPermission;
                resetForm();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var facebookAppId = (long)cbbAppId?.SelectedValue!;
            var permissionName = txtPermissionName.Text.Trim();
            var result = _facebookAppPermissionsService.Update(new FacebookAppPermissionModel
            {
                PermissionName = permissionName,
                FacebookAppId = facebookAppId
            });
            if (result)
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