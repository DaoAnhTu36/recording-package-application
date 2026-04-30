using MySql.Data.MySqlClient;
using SellerCenter.Infrastructure.Models;

namespace SellerCenter.Infrastructure
{
    public class MenuRepository
    {
        private readonly DatabaseRepository _db;

        public MenuRepository()
        {
            _db = new DatabaseRepository();
        }

        public long Create(MenuModel item)
        {
            using var conn = _db.GetConnection();
            conn.Open();

            var cmd = new MySqlCommand(@"
            INSERT INTO menus
            (
                menu_code,
                menu_name,
                parent_id,
                form_name,
                route_key,
                icon_name,
                sort_order,
                permission_code,
                is_active,
                is_visible
            )
            VALUES
            (
                @menuCode,
                @menuName,
                @parentId,
                @formName,
                @routeKey,
                @iconName,
                @sortOrder,
                @permissionCode,
                @isActive,
                @isVisible
            );

            SELECT LAST_INSERT_ID();
        ", conn);

            AddParams(cmd, item);

            return Convert.ToInt64(cmd.ExecuteScalar());
        }

        public List<MenuModel> GetAll()
        {
            var result = new List<MenuModel>();

            using var conn = _db.GetConnection();
            conn.Open();

            var cmd = new MySqlCommand(@"
            SELECT *
            FROM menus
            ORDER BY parent_id ASC, sort_order ASC, id ASC;
        ", conn);

            using var reader = cmd.ExecuteReader();

            while (reader.Read())
                result.Add(Map(reader));

            return result;
        }

        public List<MenuViewModel> GetAllWithParentName()
        {
            var result = new List<MenuViewModel>();

            using var conn = _db.GetConnection();
            conn.Open();
            var cmdString = "SELECT m.id" +
                ", m.menu_code" +
                ", m.menu_name" +
                ", m.parent_id" +
                ", p.menu_name AS parent_name" +
                ", m.form_name" +
                ", m.route_key" +
                ", m.icon_name" +
                ", m.sort_order" +
                ", m.permission_code" +
                ", m.is_active" +
                ", m.is_visible" +
                ", m.created_at" +
                ", m.updated_at " +
                "FROM menus m " +
                "LEFT JOIN menus p ON m.parent_id = p.id " +
                "ORDER BY m.created_at DESC;";
            var cmd = new MySqlCommand(cmdString, conn);

            using var reader = cmd.ExecuteReader();

            while (reader.Read())
                result.Add(MapWithParent(reader));

            return result;
        }

        public List<MenuModel> GetActiveVisible()
        {
            var result = new List<MenuModel>();

            using var conn = _db.GetConnection();
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
                result.Add(Map(reader));

            return result;
        }

        public MenuModel GetById(long id)
        {
            using var conn = _db.GetConnection();
            conn.Open();

            var cmd = new MySqlCommand(@"
            SELECT *
            FROM menus
            WHERE id = @id
            LIMIT 1;
        ", conn);

            cmd.Parameters.AddWithValue("@id", id);

            using var reader = cmd.ExecuteReader();

            if (!reader.Read())
                return null;

            return Map(reader);
        }

        public MenuModel GetByCode(string menuCode)
        {
            using var conn = _db.GetConnection();
            conn.Open();

            var cmd = new MySqlCommand(@"
            SELECT *
            FROM menus
            WHERE menu_code = @menuCode
            LIMIT 1;
        ", conn);

            cmd.Parameters.AddWithValue("@menuCode", menuCode);

            using var reader = cmd.ExecuteReader();

            if (!reader.Read())
                return null;

            return Map(reader);
        }

        public bool Update(MenuModel item)
        {
            using var conn = _db.GetConnection();
            conn.Open();

            var cmd = new MySqlCommand(@"
            UPDATE menus
            SET menu_code = @menuCode,
                menu_name = @menuName,
                parent_id = @parentId,
                form_name = @formName,
                route_key = @routeKey,
                icon_name = @iconName,
                sort_order = @sortOrder,
                permission_code = @permissionCode,
                is_active = @isActive,
                is_visible = @isVisible
            WHERE id = @id;
        ", conn);

            cmd.Parameters.AddWithValue("@id", item.Id);
            AddParams(cmd, item);

            return cmd.ExecuteNonQuery() > 0;
        }

        public bool Delete(long id)
        {
            using var conn = _db.GetConnection();
            conn.Open();

            var cmd = new MySqlCommand(@"
            DELETE FROM menus
            WHERE id = @id;
        ", conn);

            cmd.Parameters.AddWithValue("@id", id);

            return cmd.ExecuteNonQuery() > 0;
        }

        public bool SoftDelete(long id)
        {
            using var conn = _db.GetConnection();
            conn.Open();

            var cmd = new MySqlCommand(@"
            UPDATE menus
            SET is_active = 0,
                is_visible = 0
            WHERE id = @id;
        ", conn);

            cmd.Parameters.AddWithValue("@id", id);

            return cmd.ExecuteNonQuery() > 0;
        }

        public List<MenuModel> GetByParentId(long? parentId)
        {
            var result = new List<MenuModel>();

            using var conn = _db.GetConnection();
            conn.Open();

            string sql = parentId == null
                ? @"
                SELECT *
                FROM menus
                WHERE parent_id IS NULL
                ORDER BY sort_order ASC, id ASC;
            "
                : @"
                SELECT *
                FROM menus
                WHERE parent_id = @parentId
                ORDER BY sort_order ASC, id ASC;
            ";

            var cmd = new MySqlCommand(sql, conn);

            if (parentId != null)
                cmd.Parameters.AddWithValue("@parentId", parentId.Value);

            using var reader = cmd.ExecuteReader();

            while (reader.Read())
                result.Add(Map(reader));

            return result;
        }

        private void AddParams(MySqlCommand cmd, MenuModel item)
        {
            cmd.Parameters.AddWithValue("@menuCode", item.MenuCode);
            cmd.Parameters.AddWithValue("@menuName", item.MenuName);
            cmd.Parameters.AddWithValue("@parentId", item.ParentId ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@formName", item.FormName ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@routeKey", item.RouteKey ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@iconName", item.IconName ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@sortOrder", item.SortOrder);
            cmd.Parameters.AddWithValue("@permissionCode", item.PermissionCode ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@isActive", item.IsActive);
            cmd.Parameters.AddWithValue("@isVisible", item.IsVisible);
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

        private MenuViewModel MapWithParent(MySqlDataReader reader)
        {
            return new MenuViewModel
            {
                Id = reader.GetInt64("id"),
                MenuCode = reader["menu_code"]?.ToString(),
                MenuName = reader["menu_name"]?.ToString(),
                ParentId = reader["parent_id"] == DBNull.Value
                    ? null
                    : Convert.ToInt64(reader["parent_id"]),
                ParentName = reader["parent_name"]?.ToString(),
                FormName = reader["form_name"]?.ToString(),
                RouteKey = reader["route_key"]?.ToString(),
                IconName = reader["icon_name"]?.ToString(),
                SortOrder = Convert.ToInt32(reader["sort_order"]),
                PermissionCode = reader["permission_code"]?.ToString(),
                IsActive = Convert.ToBoolean(reader["is_active"]),
                IsVisible = Convert.ToBoolean(reader["is_visible"]),
                CreatedAt = Convert.ToDateTime(reader["created_at"]),
                UpdatedAt = reader["updated_at"] == DBNull.Value
                    ? null
                    : Convert.ToDateTime(reader["updated_at"])
            };
        }
    }
}