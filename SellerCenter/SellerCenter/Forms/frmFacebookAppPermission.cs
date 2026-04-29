using SellerCenter.Helpers;
using SellerCenter.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SellerCenter.Forms
{
    public partial class frmFacebookAppPermission : Form
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
            UIHelper.ApplyAll(this);
            LayoutHelper.EqualRows(tableLayoutPanel1, 3);
            var lstApp = _facebookAppsService.GetAll();
            cbbAppId.DisplayMember = "AppName";
            cbbAppId.ValueMember = "Id";

            var lstPermission = _facebookAppPermissionsService.GetWithAppName();
            MappingData();

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

        private void MappingData()
        {
            id.DataPropertyName = "id";
            permission_name.DataPropertyName = "permissionName";
            created_at.DataPropertyName = "createdAt";
            app_name.DataPropertyName = "appName";
            app_id.DataPropertyName = "appId";
        }

        private void resetForm()
        {
            cbbAppId.SelectedIndex = -1;
            txtPermissionName.Text = string.Empty;
        }
    }
}