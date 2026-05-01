using Microsoft.Extensions.Options;
using SellerCenter.Infrastructure.Configs.Model;
using SellerCenter.Infrastructure.Models;

namespace SellerCenter.Infrastructure.Implementation
{
    public class EmployeeFacebookAppsRepository : Repository<RoleModel>, IMenuRepository
    {
        private readonly string _conn;

        public EmployeeFacebookAppsRepository(IOptions<DatabaseConfig> dbConfig) : base(dbConfig.Value.ConnectionString!)
        {
            _conn = dbConfig.Value.ConnectionString!;
        }
    }
}