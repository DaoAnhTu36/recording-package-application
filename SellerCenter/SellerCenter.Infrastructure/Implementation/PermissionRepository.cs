using Microsoft.Extensions.Options;
using SellerCenter.Infrastructure.Configs.Model;
using SellerCenter.Infrastructure.Models;

namespace SellerCenter.Infrastructure.Implementation
{
    public class PermissionRepository : Repository<PermissionModel>, IPermissionRepository
    {
        private readonly string _conn;

        public PermissionRepository(IOptions<AppSettingConfig> dbConfig) : base(dbConfig.Value.DatabaseConfig!.ConnectionString!)
        {
            _conn = dbConfig.Value.DatabaseConfig!.ConnectionString!;
        }
    }
}