using Microsoft.Extensions.Options;
using SellerCenter.Infrastructure.Configs.Model;
using SellerCenter.Infrastructure.Models;

namespace SellerCenter.Infrastructure.Implementation
{
    public class ActionRepository : Repository<ActionModel>, IActionRepository
    {
        private readonly string _conn;

        public ActionRepository(IOptions<AppSettingConfig> dbConfig) : base(dbConfig.Value.DatabaseConfig!.ConnectionString!)
        {
            _conn = dbConfig.Value.DatabaseConfig!.ConnectionString!;
        }
    }
}