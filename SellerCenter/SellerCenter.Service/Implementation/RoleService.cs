using SellerCenter.Infrastructure;
using SellerCenter.Infrastructure.Models;

namespace SellerCenter.Service.Implementation
{
    public class RoleService : Service<RoleModel>, IRoleService
    {
        private readonly IMenuRepository _repository;

        public RoleService(IMenuRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}