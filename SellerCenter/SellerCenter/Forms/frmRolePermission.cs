using SellerCenter.Helpers;
using SellerCenter.Infrastructure.Extensions;
using SellerCenter.Infrastructure.Models;
using SellerCenter.Service;

namespace SellerCenter.Forms
{
    public partial class frmRolePermission : BaseForm
    {
        private readonly IRoleService _roleService;
        private readonly IPermissionService _permissionService;
        private readonly IRolePermissionService _rolePermissionService;

        public frmRolePermission()
        {
            InitializeComponent();
            _roleService = ServiceLocator.Get<IRoleService>();
            _permissionService = ServiceLocator.Get<IPermissionService>();
            _rolePermissionService = ServiceLocator.Get<IRolePermissionService>();
        }

        private void frmRolePermission_Load(object sender, EventArgs e)
        {
            var allPermission = GetAllPermission();
            RenderPermission(allPermission);

            var allRole = GetAllRole();
            RenderRole(allRole);
        }

        private List<PermissionModel> GetAllPermission()
        {
            return _permissionService.GetAllList();
        }

        private List<RoleModel> GetAllRole()
        {
            return _roleService.GetAllList();
        }

        private void RenderPermission(List<PermissionModel> permissions)
        {
            checkedListBoxPermission.DataSource = permissions;
            checkedListBoxPermission.DisplayMember = "PermissionName";
            checkedListBoxPermission.ValueMember = "Id";
        }

        private void RenderRole(List<RoleModel> roles)
        {
            cbbRole.DisplayMember = "RoleName";
            cbbRole.ValueMember = "Id";
            cbbRole.DataSource = roles;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var roleId = cbbRole.SelectedValue?.ToString()!;
            var listPermissionChecked = checkedListBoxPermission.CheckedItems
                .Cast<PermissionModel>()
                .Select(x => x.Id)
                .ToList();
            var condition = new Dictionary<string, object>
            {
                { ReflectionHelper.GetColumnName<RolePermissionModel>(x => x.RoleId), roleId }
            };
            var rolePermissionByRoleId = _rolePermissionService.GetMulti<RolePermissionModel>(ReflectionHelper.GetTableName<RolePermissionModel>(), condition);

            var listRolePermissionUnchecked = rolePermissionByRoleId.Where(x => !listPermissionChecked.Any(r => r == x.PermissionId)).ToList();

            var listRolePermissionNotExist = listPermissionChecked
                .Where(id => !rolePermissionByRoleId.Any(r => r.PermissionId == id))
                .ToList();
            if (listRolePermissionNotExist.Count > 0)
            {
                _rolePermissionService.AddRolePermissionMulti(Convert.ToInt64(roleId), listRolePermissionNotExist);
            }
            var listPermissionIdExist = listPermissionChecked
                .Where(id => rolePermissionByRoleId.Any(r => r.PermissionId == id))
                .ToList();
            var listRolePermissionExist = rolePermissionByRoleId.Where(x => listPermissionIdExist.Any(r => r == x.PermissionId)).ToList();
            if (listRolePermissionExist.Count > 0)
            {
                foreach (var rolePermission in listRolePermissionExist)
                {
                    bool isChecked = checkedListBoxPermission.CheckedItems
                        .Cast<PermissionModel>()
                        .Any(x => x.Id == rolePermission.PermissionId);
                    _rolePermissionService.UpdateStatusById(new List<long>
                    {
                        rolePermission.Id
                    }, isChecked);
                }
            }
            if (listRolePermissionUnchecked.Count > 0)
            {
                foreach (var rolePermission in listRolePermissionUnchecked)
                {
                    bool isChecked = checkedListBoxPermission.CheckedItems
                        .Cast<PermissionModel>()
                        .Any(x => x.Id == rolePermission.PermissionId);
                    _rolePermissionService.UpdateStatusById(new List<long>
                    {
                        rolePermission.Id
                    }, isChecked);
                }
            }
            MessageBox.Show("Cập nhật thành công");
        }

        private void cbbRole_TextChanged(object sender, EventArgs e)
        {
            var roleId = (long)cbbRole.SelectedValue!;
            if (roleId == 0)
            {
                return;
            }
            var condition = new Dictionary<string, object>
            {
                { ReflectionHelper.GetColumnName<RolePermissionModel>(x => x.RoleId), roleId }
            };
            var lstRolePermissionByRoleId = _rolePermissionService.GetMulti<RolePermissionModel>(ReflectionHelper.GetTableName<RolePermissionModel>(), condition);
            var selectedIds = new HashSet<long>(lstRolePermissionByRoleId.Where(x => x.IsActive).Select(x => x.PermissionId));

            for (int i = 0; i < checkedListBoxPermission.Items.Count; i++)
            {
                var item = (PermissionModel)checkedListBoxPermission.Items[i];
                checkedListBoxPermission.SetItemChecked(i, selectedIds.Contains(item.Id));
            }
        }
    }
}