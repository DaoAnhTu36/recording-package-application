using Microsoft.Extensions.Options;
using SellerCenter.Infrastructure.Configs.Model;
using SellerCenter.Infrastructure.Models;

namespace SellerCenter.Infrastructure.Implementation
{
    public class FacebookAppsRepository : Repository<FacebookAppModel>, IFacebookAppsRepository
    {
        private readonly string _conn;

        public FacebookAppsRepository(IOptions<DatabaseConfig> dbConfig) : base(dbConfig.Value.ConnectionString!)
        {
            _conn = dbConfig.Value.ConnectionString!;
        }
    }
}