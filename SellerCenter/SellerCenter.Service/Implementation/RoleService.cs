using SellerCenter.Infrastructure;
using SellerCenter.Infrastructure.Models;

namespace SellerCenter.Service.Implementation
{
    public class RoleService : Service<RoleModel>, IRoleService
    {
        private readonly IRoleRepository _repository;

        public RoleService(IRoleRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}