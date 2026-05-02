using Microsoft.Extensions.Options;
using MySql.Data.MySqlClient;
using SellerCenter.Infrastructure.Configs.Model;
using SellerCenter.Infrastructure.Models;

namespace SellerCenter.Infrastructure.Implementation
{
    public class FacebookAppPermissionsRepository : Repository<FacebookAppPermissionModel>, IFacebookAppPermissionsRepository
    {
        private readonly string _conn;

        public FacebookAppPermissionsRepository(IOptions<AppSettingConfig> dbConfig) : base(dbConfig.Value.DatabaseConfig!.ConnectionString!)
        {
            _conn = dbConfig.Value.DatabaseConfig!.ConnectionString!;
        }

        public async Task<List<FacebookAppPermissionWithAppNameModel>> GetWithAppName()
        {
            var result = new List<FacebookAppPermissionWithAppNameModel>();

            using var conn = new MySqlConnection(_conn);
            conn.Open();

            var cmd = new MySqlCommand(@"
                SELECT fap.id, fap.permission_name, fap.created_at, fa.app_name, fa.app_id
                FROM facebook_app_permissions AS fap
                JOIN facebook_apps AS fa ON fap.facebook_app_id = fa.id
                WHERE 1 = 1
                ORDER BY id DESC;
            ", conn);
            using var reader = await cmd.ExecuteReaderAsync();

            while (reader.Read())
            {
                result.Add(new FacebookAppPermissionWithAppNameModel
                {
                    Id = (long)reader["id"],
                    PermissionName = reader["permission_name"].ToString(),
                    CreatedAt = reader["created_at"] == DBNull.Value ? null : (DateTime)reader["created_at"],
                    AppName = reader["app_name"].ToString(),
                    AppId = reader["app_id"].ToString()
                });
            }

            return result;
        }
    }
}