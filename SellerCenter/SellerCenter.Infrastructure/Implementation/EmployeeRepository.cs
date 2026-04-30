using MySql.Data.MySqlClient;
using SellerCenter.Helper;
using SellerCenter.Infrastructure.Models;

namespace SellerCenter.Infrastructure.Implementation
{
    public class EmployeeRepository : IRepository<EmployeeModel>, IEmployeeRepository
    {
        private DatabaseRepository _db;

        public EmployeeRepository()
        {
            _db = new DatabaseRepository();
        }

        public EmployeeModel Login(string login)
        {
            using var conn = _db.GetConnection();
            conn.Open();

            var cmd = new MySqlCommand(@"
                    SELECT *
                    FROM employees
                    WHERE is_active = 1
                    AND (
                        username = @login
                        OR email = @login
                    )
                    LIMIT 1
                ", conn);

            cmd.Parameters.AddWithValue("@login", login);

            using (var reader = cmd.ExecuteReader())
            {
                if (!reader.Read())
                    return null!;

                var user = new EmployeeModel
                {
                    Id = reader.GetInt64("id"),
                    Username = reader["username"].ToString(),
                    Email = reader["email"].ToString(),
                    PasswordHash = reader["password_hash"].ToString(),
                    FullName = reader["full_name"].ToString(),
                    Phone = reader["phone"].ToString(),
                    Role = reader["role"].ToString()
                };

                return user;
            }
        }

        public string CreateSession(long userId, string ipLocal)
        {
            using var conn = _db.GetConnection();
            conn.Open();
            string token = Guid.NewGuid().ToString();

            var cmd = new MySqlCommand(@"
                INSERT INTO login_sessions
                (employee_id, session_token, ip_address, device_name)
                VALUES (@userId, @token, @ip, @device)
            ", conn);

            cmd.Parameters.AddWithValue("@userId", userId);
            cmd.Parameters.AddWithValue("@token", token);
            cmd.Parameters.AddWithValue("@ip", ipLocal);
            cmd.Parameters.AddWithValue("@device", Environment.MachineName);

            cmd.ExecuteNonQuery();

            return token;
        }

        public void Logout()
        {
            using var conn = _db.GetConnection();
            conn.Open();
            var cmd = new MySqlCommand(@"
                    UPDATE login_sessions
                    SET is_active = 0,
                        logout_time = NOW()
                    WHERE session_token = @token
                ", conn);
            cmd.Parameters.AddWithValue("@token", SessionManager.SessionToken);
            cmd.ExecuteNonQuery();
        }

        public long Create(EmployeeModel item)
        {
            using var conn = _db.GetConnection();
            conn.Open();

            string passwordHash = PasswordHelper.HashPassword(item.PasswordHash!);

            var cmd = new MySqlCommand(@"
            INSERT INTO employees
            (username, email, password_hash, full_name, phone, role, is_active)
            VALUES
            (@username, @email, @passwordHash, @fullName, @phone, @role, @isActive);

            SELECT LAST_INSERT_ID();
        ", conn);

            cmd.Parameters.AddWithValue("@username", item.Username);
            cmd.Parameters.AddWithValue("@email", item.Email);
            cmd.Parameters.AddWithValue("@passwordHash", passwordHash);
            cmd.Parameters.AddWithValue("@fullName", item.FullName);
            cmd.Parameters.AddWithValue("@phone", item.Phone);
            cmd.Parameters.AddWithValue("@role", item.Role);
            cmd.Parameters.AddWithValue("@isActive", item.IsActive);

            return Convert.ToInt64(cmd.ExecuteScalar());
        }

        public List<EmployeeModel> GetAll()
        {
            var result = new List<EmployeeModel>();

            using var conn = _db.GetConnection();
            conn.Open();

            var cmd = new MySqlCommand(@"
            SELECT id, username, email, password_hash, full_name, phone, role,
                   is_active, created_at, updated_at
            FROM employees
            ORDER BY id DESC;
        ", conn);

            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                result.Add(MapEmployee(reader));
            }

            return result;
        }

        public EmployeeModel GetById(long id)
        {
            using var conn = _db.GetConnection();
            conn.Open();

            var cmd = new MySqlCommand(@"
            SELECT id, username, email, password_hash, full_name, phone, role,
                   is_active, created_at, updated_at
            FROM employees
            WHERE id = @id
            LIMIT 1;
        ", conn);

            cmd.Parameters.AddWithValue("@id", id);

            using var reader = cmd.ExecuteReader();

            if (!reader.Read())
                return null;

            return MapEmployee(reader);
        }

        public bool Update(EmployeeModel item)
        {
            using var conn = _db.GetConnection();
            conn.Open();

            var cmd = new MySqlCommand(@"
            UPDATE employees
            SET username = @username,
                email = @email,
                full_name = @fullName,
                phone = @phone,
                role = @role,
                is_active = @isActive
            WHERE id = @id;
        ", conn);

            cmd.Parameters.AddWithValue("@id", item.Id);
            cmd.Parameters.AddWithValue("@username", item.Username);
            cmd.Parameters.AddWithValue("@email", item.Email);
            cmd.Parameters.AddWithValue("@fullName", item.FullName);
            cmd.Parameters.AddWithValue("@phone", item.Phone);
            cmd.Parameters.AddWithValue("@role", item.Role);
            cmd.Parameters.AddWithValue("@isActive", item.IsActive);

            return cmd.ExecuteNonQuery() > 0;
        }

        public bool UpdatePassword(long id, string newPassword)
        {
            using var conn = _db.GetConnection();
            conn.Open();

            string passwordHash = PasswordHelper.HashPassword(newPassword);

            var cmd = new MySqlCommand(@"
            UPDATE employees
            SET password_hash = @passwordHash
            WHERE id = @id;
        ", conn);

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@passwordHash", passwordHash);

            return cmd.ExecuteNonQuery() > 0;
        }

        public bool Delete(long id)
        {
            using var conn = _db.GetConnection();
            conn.Open();

            var cmd = new MySqlCommand(@"
            DELETE FROM employees
            WHERE id = @id;
        ", conn);

            cmd.Parameters.AddWithValue("@id", id);

            return cmd.ExecuteNonQuery() > 0;
        }

        private EmployeeModel MapEmployee(MySqlDataReader reader)
        {
            return new EmployeeModel
            {
                Id = reader.GetInt64("id"),
                Username = reader["username"]?.ToString(),
                Email = reader["email"]?.ToString(),
                PasswordHash = reader["password_hash"]?.ToString(),
                FullName = reader["full_name"]?.ToString(),
                Phone = reader["phone"]?.ToString(),
                Role = reader["role"]?.ToString(),
                IsActive = Convert.ToBoolean(reader["is_active"]),
                CreatedAt = Convert.ToDateTime(reader["created_at"]),
                UpdatedAt = reader["updated_at"] == DBNull.Value
                    ? null
                    : Convert.ToDateTime(reader["updated_at"])
            };
        }
    }
}