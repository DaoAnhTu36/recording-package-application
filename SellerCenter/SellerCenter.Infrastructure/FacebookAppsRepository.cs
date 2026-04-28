using MySql.Data.MySqlClient;
using SellerCenter.Infrastructure.Models;

namespace SellerCenter.Infrastructure
{
    public class FacebookAppModelsRepository
    {
        private readonly DatabaseRepository _db;

        public FacebookAppModelsRepository()
        {
            _db = new DatabaseRepository();
        }

        public long Create(FacebookAppModel item)
        {
            using var conn = _db.GetConnection();
            conn.Open();

            var cmd = new MySqlCommand(@"
                INSERT INTO facebook_apps
                (app_name, app_id, app_secret, is_active)
                VALUES
                (@appName, @appId, @appSecret, @isActive);

                SELECT LAST_INSERT_ID();
            ", conn);

            cmd.Parameters.AddWithValue("@appName", item.AppName);
            cmd.Parameters.AddWithValue("@appId", item.AppId);
            cmd.Parameters.AddWithValue("@appSecret", item.AppSecret);
            cmd.Parameters.AddWithValue("@isActive", item.IsActive);

            return Convert.ToInt64(cmd.ExecuteScalar());
        }

        public List<FacebookAppModel> GetAll()
        {
            var result = new List<FacebookAppModel>();

            using var conn = _db.GetConnection();
            conn.Open();

            var cmd = new MySqlCommand(@"
                SELECT id, app_name, app_id, app_secret, is_active
                FROM facebook_apps
                ORDER BY id DESC;
            ", conn);

            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                result.Add(new FacebookAppModel
                {
                    Id = reader.GetInt64("id"),
                    AppName = reader["app_name"].ToString(),
                    AppId = reader["app_id"].ToString(),
                    AppSecret = reader["app_secret"]?.ToString(),
                    IsActive = Convert.ToBoolean(reader["is_active"])
                });
            }

            return result;
        }

        public FacebookAppModel GetById(long id)
        {
            using var conn = _db.GetConnection();
            conn.Open();

            var cmd = new MySqlCommand(@"
                SELECT id, app_name, app_id, app_secret, is_active
                FROM facebook_apps
                WHERE id = @id
                LIMIT 1;
            ", conn);

            cmd.Parameters.AddWithValue("@id", id);

            using var reader = cmd.ExecuteReader();

            if (!reader.Read())
                return null!;

            return new FacebookAppModel
            {
                Id = reader.GetInt64("id"),
                AppName = reader["app_name"].ToString(),
                AppId = reader["app_id"].ToString(),
                AppSecret = reader["app_secret"]?.ToString(),
                IsActive = Convert.ToBoolean(reader["is_active"])
            };
        }

        public bool Update(FacebookAppModel item)
        {
            using var conn = _db.GetConnection();
            conn.Open();

            var cmd = new MySqlCommand(@"
                UPDATE facebook_apps
                SET app_name = @appName,
                    app_id = @appId,
                    app_secret = @appSecret,
                    is_active = @isActive
                WHERE id = @id;
            ", conn);

            cmd.Parameters.AddWithValue("@id", item.Id);
            cmd.Parameters.AddWithValue("@appName", item.AppName);
            cmd.Parameters.AddWithValue("@appId", item.AppId);
            cmd.Parameters.AddWithValue("@appSecret", item.AppSecret);
            cmd.Parameters.AddWithValue("@isActive", item.IsActive);

            return cmd.ExecuteNonQuery() > 0;
        }

        public bool Delete(long id)
        {
            using var conn = _db.GetConnection();
            conn.Open();

            var cmd = new MySqlCommand(@"
                DELETE FROM facebook_apps
                WHERE id = @id;
            ", conn);

            cmd.Parameters.AddWithValue("@id", id);

            return cmd.ExecuteNonQuery() > 0;
        }
    }
}