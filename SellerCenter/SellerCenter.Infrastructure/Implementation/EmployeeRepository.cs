using Microsoft.Extensions.Options;
using MySql.Data.MySqlClient;
using SellerCenter.Helper;
using SellerCenter.Infrastructure.Configs.Model;
using SellerCenter.Infrastructure.Models;

namespace SellerCenter.Infrastructure.Implementation
{
    public class EmployeeRepository : Repository<EmployeeModel>, IEmployeeRepository
    {
        private readonly string _conn;

        public EmployeeRepository(IOptions<DatabaseConfig> dbConfig) : base(dbConfig.Value.ConnectionString!)
        {
            _conn = dbConfig.Value.ConnectionString!;
        }

        public async Task<EmployeeModel> Login(string login)
        {
            using var conn = new MySqlConnection(_conn);
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
            using (var reader = await cmd.ExecuteReaderAsync())
            {
                if (!reader.Read())
                    return null!;
                var user = new EmployeeModel
                {
                    Id = (long)reader["id"],
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

        public async Task<string> CreateSession(long userId, string ipLocal)
        {
            using var conn = new MySqlConnection(_conn);
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
            await cmd.ExecuteNonQueryAsync();
            return token;
        }

        public async Task Logout()
        {
            using var conn = new MySqlConnection(_conn);
            conn.Open();
            var cmd = new MySqlCommand(@"
                    UPDATE login_sessions
                    SET is_active = 0,
                        logout_time = NOW()
                    WHERE session_token = @token
                ", conn);
            cmd.Parameters.AddWithValue("@token", SessionManager.SessionToken);
            await cmd.ExecuteNonQueryAsync();
        }

        public async Task<bool> UpdatePassword(long id, string newPassword)
        {
            using var conn = new MySqlConnection(_conn);
            conn.Open();
            string passwordHash = PasswordHelper.HashPassword(newPassword);
            var cmd = new MySqlCommand(@"
            UPDATE employees
            SET password_hash = @passwordHash
            WHERE id = @id;
        ", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@passwordHash", passwordHash);
            return await cmd.ExecuteNonQueryAsync() > 0;
        }
    }
}