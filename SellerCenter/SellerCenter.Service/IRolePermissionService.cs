using SellerCenter.Infrastructure.Models;

namespace SellerCenter.Service
{
    public interface IRolePermissionService : IService<RolePermissionModel>
    {
        bool UpdateStatusById(List<long> rolePermissionId, bool status);

        bool AddRolePermissionMulti(long roleId, List<long> permissionIds);
    }
}