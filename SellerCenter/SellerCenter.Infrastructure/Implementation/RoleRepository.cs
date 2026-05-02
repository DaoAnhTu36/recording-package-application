using Microsoft.Extensions.Options;
using SellerCenter.Infrastructure.Configs.Model;
using SellerCenter.Infrastructure.Models;

namespace SellerCenter.Infrastructure.Implementation
{
    public class RoleRepository : Repository<RoleModel>, IRoleRepository
    {
        private readonly string _conn;

        public RoleRepository(IOptions<DatabaseConfig> dbConfig) : base(dbConfig.Value.ConnectionString!)
        {
            _conn = dbConfig.Value.ConnectionString!;
        }
    }
}