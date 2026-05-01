using Microsoft.Extensions.Options;
using MySql.Data.MySqlClient;
using SellerCenter.Infrastructure.Configs.Model;
using SellerCenter.Infrastructure.Models;

namespace SellerCenter.Infrastructure.Implementation
{
    public class MenuRepository : Repository<MenuModel>, IMenuRepository
    {
        private readonly string _conn;

        public MenuRepository(IOptions<DatabaseConfig> dbConfig) : base(dbConfig.Value.ConnectionString!)
        {
            _conn = dbConfig.Value.ConnectionString!;
        }

        public async Task<List<MenuModel>> GetActiveVisible()
        {
            var result = new List<MenuModel>();

            using var conn = new MySqlConnection(_conn);
            conn.Open();

            var cmd = new MySqlCommand(@"
            SELECT *
            FROM menus
            WHERE is_active = 1
              AND is_visible = 1
            ORDER BY parent_id ASC, sort_order ASC, id ASC;
        ", conn);

            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                result.Add(Map(reader));
            }

            return result;
        }

        public async Task<List<MenuViewModel>> GetAllWithParentName()
        {
            throw new NotImplementedException();
        }

        public async Task<MenuModel> GetByCode(string menuCode)
        {
            throw new NotImplementedException();
        }

        public async Task<List<MenuModel>> GetByParentId(long? parentId)
        {
            throw new NotImplementedException();
        }
        private MenuModel Map(MySqlDataReader reader)
        {
            return new MenuModel
            {
                Id = reader.GetInt64("id"),
                MenuCode = reader["menu_code"]?.ToString(),
                MenuName = reader["menu_name"]?.ToString(),
                ParentId = reader["parent_id"] == DBNull.Value ? null : Convert.ToInt64(reader["parent_id"]),
                FormName = reader["form_name"]?.ToString(),
                RouteKey = reader["route_key"]?.ToString(),
                IconName = reader["icon_name"]?.ToString(),
                SortOrder = Convert.ToInt32(reader["sort_order"]),
                PermissionCode = reader["permission_code"]?.ToString(),
                IsActive = Convert.ToBoolean(reader["is_active"]),
                IsVisible = Convert.ToBoolean(reader["is_visible"]),
                CreatedAt = Convert.ToDateTime(reader["created_at"]),
                UpdatedAt = reader["updated_at"] == DBNull.Value ? null : Convert.ToDateTime(reader["updated_at"])
            };
        }
    }
}