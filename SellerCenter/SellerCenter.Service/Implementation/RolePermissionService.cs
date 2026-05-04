using SellerCenter.Infrastructure;
using SellerCenter.Infrastructure.Models;

namespace SellerCenter.Service.Implementation
{
    public class RolePermissionService : Service<RolePermissionModel>, IRolePermissionService
    {
        private readonly IRolePermissionRepository _repository;

        public RolePermissionService(IRolePermissionRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public bool UpdateStatusById(List<long> rolePermissionId, bool status)
        {
            return _repository.UpdateStatusById(rolePermissionId, status);
        }

        public bool AddRolePermissionMulti(long roleId, List<long> permissionIds)
        {
            return _repository.AddRolePermissionMulti(roleId, permissionIds);
        }
    }
}