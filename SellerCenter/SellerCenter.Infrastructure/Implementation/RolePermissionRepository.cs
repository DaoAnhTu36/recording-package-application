using Microsoft.Extensions.Options;
using MySql.Data.MySqlClient;
using SellerCenter.Infrastructure.Configs.Model;
using SellerCenter.Infrastructure.Models;

namespace SellerCenter.Infrastructure.Implementation
{
    public class RolePermissionRepository : Repository<RolePermissionModel>, IRolePermissionRepository
    {
        private readonly string _conn;

        public RolePermissionRepository(IOptions<AppSettingConfig> dbConfig) : base(dbConfig.Value.DatabaseConfig!.ConnectionString!)
        {
            _conn = dbConfig.Value.DatabaseConfig!.ConnectionString!;
        }

        public bool UpdateStatusById(List<long> rolePermissionId, bool status)
        {
            if (rolePermissionId == null || rolePermissionId.Count == 0)
                return false;

            using var conn = new MySqlConnection(_conn);
            conn.Open();

            var paramNames = rolePermissionId.Select((x, i) => $"@p{i}").ToList();

            string query = $@"
                UPDATE role_permissions
                SET is_active = @status
                WHERE id IN ({string.Join(",", paramNames)})
            ";

            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@status", status ? 1 : 0);
            for (int i = 0; i < rolePermissionId.Count; i++)
            {
                cmd.Parameters.AddWithValue(paramNames[i], rolePermissionId[i]);
            }

            int affected = cmd.ExecuteNonQuery();

            return affected > 0;
        }

        public bool AddRolePermissionMulti(long roleId, List<long> permissionIds)
        {
            if (permissionIds == null || permissionIds.Count == 0)
                return false;

            using var conn = new MySqlConnection(_conn);
            conn.Open();

            using var tran = conn.BeginTransaction();

            try
            {
                var values = new List<string>();
                var cmd = new MySqlCommand
                {
                    Connection = conn,
                    Transaction = tran
                };

                for (int i = 0; i < permissionIds.Count; i++)
                {
                    string pRole = $"@role{i}";
                    string pPer = $"@per{i}";

                    values.Add($"({pRole}, {pPer}, 1)");

                    cmd.Parameters.AddWithValue(pRole, roleId);
                    cmd.Parameters.AddWithValue(pPer, permissionIds[i]);
                }

                cmd.CommandText = $@"
                    INSERT INTO role_permissions (role_id, permission_id, is_active)
                    VALUES {string.Join(",", values)}
                ";

                cmd.ExecuteNonQuery();
                tran.Commit();

                return true;
            }
            catch
            {
                tran.Rollback();
                throw;
            }
        }
    }
}