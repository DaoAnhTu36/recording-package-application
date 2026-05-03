using SellerCenter.Helpers;
using SellerCenter.Infrastructure.Models;
using SellerCenter.Service;

namespace SellerCenter.Forms
{
    public partial class frmRolePermission : BaseForm
    {
        private readonly IRoleService _roleService;
        private readonly IPermissionService _permissionService;

        public frmRolePermission()
        {
            InitializeComponent();
            _roleService = ServiceLocator.Get<IRoleService>();
            _permissionService = ServiceLocator.Get<IPermissionService>();
        }

        private void frmRolePermission_Load(object sender, EventArgs e)
        {
            GetAllRole();
            var allPermission = GetAllPermission();
            RenderPermission(allPermission);
        }

        private void GetAllRole()
        {
            _roleService.GetAllList();
        }

        private List<PermissionModel> GetAllPermission()
        {
            return _permissionService.GetAllList();
        }

        private void RenderPermission(List<PermissionModel> permissions)
        {
            foreach (var permission in permissions)
            {
                flowLayoutPanel1.Controls.Add(new CheckBox { Text = permission.PermissionName });
            }
        }
    }
}