using SellerCenter.Infrastructure.Models;

namespace SellerCenter.Infrastructure
{
    public interface IRolePermissionRepository : IRepository<RolePermissionModel>
    {
        bool UpdateStatusById(List<long> rolePermissionId, bool status);

        bool AddRolePermissionMulti(long roleId, List<long> permissionIds);
    }
}