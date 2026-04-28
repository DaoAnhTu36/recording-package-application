using MySql.Data.MySqlClient;
using SellerCenter.Infrastructure.Models;

namespace SellerCenter.Infrastructure
{
    public class FacebookAppPermissionRepository
    {
        private readonly DatabaseRepository _db;

        public FacebookAppPermissionRepository()
        {
            _db = new DatabaseRepository();
        }

        public long Create(FacebookAppPermissionModel item)
        {
            using var conn = _db.GetConnection();
            conn.Open();

            var cmd = new MySqlCommand(@"
                INSERT INTO facebook_app_permissions
                (facebook_app_id, permission_name)
                VALUES
                (@facebookAppId, @permissionName);

                SELECT LAST_INSERT_ID();
            ", conn);

            cmd.Parameters.AddWithValue("@facebookAppId", item.FacebookAppId);
            cmd.Parameters.AddWithValue("@permissionName", item.PermissionName);

            return Convert.ToInt64(cmd.ExecuteScalar());
        }

        public List<FacebookAppPermissionModel> GetByFacebookAppId(long facebookAppId)
        {
            var result = new List<FacebookAppPermissionModel>();

            using var conn = _db.GetConnection();
            conn.Open();

            var cmd = new MySqlCommand(@"
                SELECT id, facebook_app_id, permission_name
                FROM facebook_app_permissions
                WHERE facebook_app_id = @facebookAppId
                ORDER BY id DESC;
            ", conn);

            cmd.Parameters.AddWithValue("@facebookAppId", facebookAppId);

            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                result.Add(new FacebookAppPermissionModel
                {
                    Id = reader.GetInt64("id"),
                    FacebookAppId = reader.GetInt64("facebook_app_id"),
                    PermissionName = reader["permission_name"].ToString()
                });
            }

            return result;
        }

        public List<FacebookAppPermissionModel> GetAll()
        {
            var result = new List<FacebookAppPermissionModel>();

            using var conn = _db.GetConnection();
            conn.Open();

            var cmd = new MySqlCommand(@"
                SELECT id, facebook_app_id, permission_name, created_at
                FROM facebook_app_permissions
                WHERE 1 = 1
                ORDER BY id DESC;
            ", conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                result.Add(new FacebookAppPermissionModel
                {
                    Id = reader.GetInt64("id"),
                    FacebookAppId = reader.GetInt64("facebook_app_id"),
                    PermissionName = reader["permission_name"].ToString(),
                    CreatedAt = reader["created_at"] == DBNull.Value ? (DateTime?)null : reader.GetDateTime("created_at"),
                });
            }

            return result;
        }

        public List<FacebookAppPermissionWithAppNameModel> GetWithAppName()
        {
            var result = new List<FacebookAppPermissionWithAppNameModel>();

            using var conn = _db.GetConnection();
            conn.Open();

            var cmd = new MySqlCommand(@"
                SELECT fap.id, fap.permission_name, fap.created_at, fa.app_name, fa.app_id
                FROM facebook_app_permissions AS fap
                JOIN facebook_apps AS fa ON fap.facebook_app_id = fa.id
                WHERE 1 = 1
                ORDER BY id DESC;
            ", conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                result.Add(new FacebookAppPermissionWithAppNameModel
                {
                    Id = reader.GetInt64("id"),
                    PermissionName = reader["permission_name"].ToString(),
                    CreatedAt = reader["created_at"] == DBNull.Value ? (DateTime?)null : reader.GetDateTime("created_at"),
                    AppName = reader["app_name"].ToString(),
                    AppId = reader["app_id"].ToString()
                });
            }

            return result;
        }

        public bool Update(FacebookAppPermissionModel item)
        {
            using var conn = _db.GetConnection();
            conn.Open();

            var cmd = new MySqlCommand(@"
                UPDATE facebook_app_permissions
                SET permission_name = @permissionName
                WHERE id = @id;
            ", conn);

            cmd.Parameters.AddWithValue("@id", item.Id);
            cmd.Parameters.AddWithValue("@permissionName", item.PermissionName);

            return cmd.ExecuteNonQuery() > 0;
        }

        public bool Delete(long id)
        {
            using var conn = _db.GetConnection();
            conn.Open();

            var cmd = new MySqlCommand(@"
                DELETE FROM facebook_app_permissions
                WHERE id = @id;
            ", conn);

            cmd.Parameters.AddWithValue("@id", id);

            return cmd.ExecuteNonQuery() > 0;
        }

        public bool DeleteByFacebookAppId(long facebookAppId)
        {
            using var conn = _db.GetConnection();
            conn.Open();

            var cmd = new MySqlCommand(@"
                DELETE FROM facebook_app_permissions
                WHERE facebook_app_id = @facebookAppId;
            ", conn);

            cmd.Parameters.AddWithValue("@facebookAppId", facebookAppId);

            return cmd.ExecuteNonQuery() > 0;
        }
    }
}