using SellerCenter.Helpers;
using SellerCenter.Service;

namespace SellerCenter.Forms
{
    public partial class frmFacebookAppManager : BaseForm
    {
        private readonly FacebookAppsService _facebookAppService;

        public frmFacebookAppManager()
        {
            InitializeComponent();
            _facebookAppService = new FacebookAppsService();
        }

        private void frmFacebookAppManager_Load(object sender, EventArgs e)
        {
            LayoutHelper.EqualRows(tableLayoutPanel1, 3);
            onLoad();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            var appId = txtAppId.Text.Trim();
            var appName = txtAppName.Text.Trim();
            if (string.IsNullOrEmpty(appId) || string.IsNullOrEmpty(appName))
            {
                MessageBox.Show("Mã ứng dụng, tên ứng dụng không được để trống.");
                btnSave.Enabled = true;
                return;
            }
            _facebookAppService.Create(appName, appId, "", true);
            reset();
            onLoad();
        }

        private void onLoad()
        {
            var apps = _facebookAppService.GetAll();
            dataGridView1.DataSource = apps;
        }

        private void reset()
        {
            txtAppId.Text = "";
            txtAppName.Text = "";
            btnSave.Enabled = true;
            btnUpdate.Visible = false;
        }
    }
}