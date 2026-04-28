using MySql.Data.MySqlClient;
using SellerCenter.Infrastructure.Models;

namespace SellerCenter.Infrastructure
{
    public class EmployeeFacebookAppModelsRepository
    {
        private readonly DatabaseRepository _db;

        public EmployeeFacebookAppModelsRepository()
        {
            _db = new DatabaseRepository();
        }

        public long Create(EmployeeFacebookAppModel item)
        {
            using var conn = _db.GetConnection();
            conn.Open();

            var cmd = new MySqlCommand(@"
                INSERT INTO employee_facebook_apps
                (
                    employee_id,
                    facebook_app_id,
                    can_view,
                    can_get_token,
                    can_post,
                    can_update,
                    can_delete,
                    assigned_by
                )
                VALUES
                (
                    @employeeId,
                    @facebookAppId,
                    @canView,
                    @canGetToken,
                    @canPost,
                    @canUpdate,
                    @canDelete,
                    @assignedBy
                );

                SELECT LAST_INSERT_ID();
            ", conn);

            cmd.Parameters.AddWithValue("@employeeId", item.EmployeeId);
            cmd.Parameters.AddWithValue("@facebookAppId", item.FacebookAppId);
            cmd.Parameters.AddWithValue("@canView", item.CanView);
            cmd.Parameters.AddWithValue("@canGetToken", item.CanGetToken);
            cmd.Parameters.AddWithValue("@canPost", item.CanPost);
            cmd.Parameters.AddWithValue("@canUpdate", item.CanUpdate);
            cmd.Parameters.AddWithValue("@canDelete", item.CanDelete);
            cmd.Parameters.AddWithValue("@assignedBy", item.AssignedBy.HasValue ? item.AssignedBy.Value : DBNull.Value);

            return Convert.ToInt64(cmd.ExecuteScalar());
        }

        public List<EmployeeFacebookAppModel> GetByEmployeeId(long employeeId)
        {
            var result = new List<EmployeeFacebookAppModel>();

            using var conn = _db.GetConnection();
            conn.Open();

            var cmd = new MySqlCommand(@"
                SELECT
                    id,
                    employee_id,
                    facebook_app_id,
                    can_view,
                    can_get_token,
                    can_post,
                    can_update,
                    can_delete,
                    assigned_by
                FROM employee_facebook_apps
                WHERE employee_id = @employeeId
                ORDER BY id DESC;
            ", conn);

            cmd.Parameters.AddWithValue("@employeeId", employeeId);

            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                result.Add(new EmployeeFacebookAppModel
                {
                    Id = reader.GetInt64("id"),
                    EmployeeId = reader.GetInt64("employee_id"),
                    FacebookAppId = reader.GetInt64("facebook_app_id"),
                    CanView = Convert.ToBoolean(reader["can_view"]),
                    CanGetToken = Convert.ToBoolean(reader["can_get_token"]),
                    CanPost = Convert.ToBoolean(reader["can_post"]),
                    CanUpdate = Convert.ToBoolean(reader["can_update"]),
                    CanDelete = Convert.ToBoolean(reader["can_delete"]),
                    AssignedBy = reader["assigned_by"] == DBNull.Value ? null : Convert.ToInt64(reader["assigned_by"])
                });
            }

            return result;
        }

        public bool Update(EmployeeFacebookAppModel item)
        {
            using var conn = _db.GetConnection();
            conn.Open();

            var cmd = new MySqlCommand(@"
            UPDATE employee_facebook_apps
            SET can_view = @canView,
                can_get_token = @canGetToken,
                can_post = @canPost,
                can_update = @canUpdate,
                can_delete = @canDelete
            WHERE id = @id;
        ", conn);

            cmd.Parameters.AddWithValue("@id", item.Id);
            cmd.Parameters.AddWithValue("@canView", item.CanView);
            cmd.Parameters.AddWithValue("@canGetToken", item.CanGetToken);
            cmd.Parameters.AddWithValue("@canPost", item.CanPost);
            cmd.Parameters.AddWithValue("@canUpdate", item.CanUpdate);
            cmd.Parameters.AddWithValue("@canDelete", item.CanDelete);

            return cmd.ExecuteNonQuery() > 0;
        }

        public bool Delete(long id)
        {
            using var conn = _db.GetConnection();
            conn.Open();

            var cmd = new MySqlCommand(@"
            DELETE FROM employee_facebook_apps
            WHERE id = @id;
        ", conn);

            cmd.Parameters.AddWithValue("@id", id);

            return cmd.ExecuteNonQuery() > 0;
        }

        public bool HasPostPermission(long employeeId, long facebookAppId)
        {
            using var conn = _db.GetConnection();
            conn.Open();

            var cmd = new MySqlCommand(@"
            SELECT COUNT(1)
            FROM employee_facebook_apps
            WHERE employee_id = @employeeId
              AND facebook_app_id = @facebookAppId
              AND can_post = 1;
        ", conn);

            cmd.Parameters.AddWithValue("@employeeId", employeeId);
            cmd.Parameters.AddWithValue("@facebookAppId", facebookAppId);

            return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
        }
    }
}