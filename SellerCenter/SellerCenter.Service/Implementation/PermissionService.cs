using SellerCenter.Infrastructure;
using SellerCenter.Infrastructure.Models;

namespace SellerCenter.Service.Implementation
{
    public class PermissionService : Service<PermissionModel>, IPermissionService
    {
        private readonly IPermissionRepository _repository;

        public PermissionService(IPermissionRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}