using Microsoft.Extensions.Options;
using SellerCenter.Infrastructure.Configs.Model;
using SellerCenter.Infrastructure.Models;

namespace SellerCenter.Infrastructure.Implementation
{
    public class FormRepository : Repository<FormModel>, IFormRepository
    {
        private readonly string _conn;

        public FormRepository(IOptions<AppSettingConfig> dbConfig) : base(dbConfig.Value.DatabaseConfig!.ConnectionString!)
        {
            _conn = dbConfig.Value.DatabaseConfig!.ConnectionString!;
        }
    }
}