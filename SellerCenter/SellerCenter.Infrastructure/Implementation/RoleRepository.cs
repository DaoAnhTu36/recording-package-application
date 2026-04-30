using SellerCenter.Infrastructure.Models;

namespace SellerCenter.Infrastructure.Implementation
{
    public class RoleRepository : Repository<RoleModel>, IRoleRepository
    {
        public RoleRepository(string conn) : base(conn)
        {
        }
    }
}