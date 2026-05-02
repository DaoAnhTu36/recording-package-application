using MySql.Data.MySqlClient;
using SellerCenter.Infrastructure.Extensions;
using SellerCenter.Infrastructure.Models;
using System.Data;
using System.Reflection;
using System.Text.Json.Serialization;

namespace SellerCenter.Infrastructure.Implementation
{
    public class Repository<T> : IRepository<T> where T : class, IEntity, new()
    {
        private readonly string _conn;
        private readonly string _tableName;

        public Repository(string conn)
        {
            _conn = conn;
            _tableName = ReflectionHelper.GetTableName<T>();
        }

        public long Create(T entity)
        {
            using var conn = new MySqlConnection(_conn);
            conn.Open();

            var props = typeof(T).GetProperties()
                .Where(p => p.Name != "Id");

            var columns = string.Join(", ", props.Select(p =>
            {
                var attr = p.GetCustomAttribute<JsonPropertyNameAttribute>();
                return attr != null ? attr.Name : p.Name;
            }));

            var values = string.Join(", ", props.Select(p => "@" + p.Name));

            var cmd = new MySqlCommand($@"
                INSERT INTO {_tableName} ({columns})
                VALUES ({values});
                SELECT LAST_INSERT_ID();", conn);

            foreach (var prop in props)
            {
                cmd.Parameters.AddWithValue("@" + prop.Name,
                    prop.GetValue(entity) ?? DBNull.Value);
            }
            try
            {
                return Convert.ToInt64(cmd.ExecuteScalar());
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                {
                    throw new Exception("Dữ liệu đã tồn tại (duplicate key).");
                }

                throw;
            }
        }

        public List<T> GetAllList()
        {
            var list = new List<T>();

            using var conn = new MySqlConnection(_conn);
            conn.Open();

            var cmd = new MySqlCommand($"SELECT * FROM {_tableName}", conn);

            try
            {
                using var rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    list.Add(MapWithJsonProperty(rd));
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }

        public DataTable GetAll()
        {
            var list = new List<T>();

            using var conn = new MySqlConnection(_conn);
            conn.Open();

            var cmd = new MySqlCommand($"SELECT * FROM {_tableName}", conn);

            try
            {
                using var adapter = new MySqlDataAdapter(cmd);
                var table = new DataTable();
                adapter.Fill(table);
                return table;
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable SearchByKey(string tableName, string keyword, params string[] columns)
        {
            using (var conn = new MySqlConnection(_conn))
            {
                conn.Open();

                var query = $"SELECT * FROM {tableName} WHERE ";

                var conditions = new List<string>();

                for (int i = 0; i < columns.Length; i++)
                {
                    conditions.Add($"{columns[i]} LIKE @keyword");
                }

                query += string.Join(" OR ", conditions);

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@keyword", $"%{keyword}%");

                    var adapter = new MySqlDataAdapter(cmd);
                    var table = new DataTable();
                    adapter.Fill(table);

                    return table;
                }
            }
        }

        public bool IsExists(string tableName, string keyword, string columns)
        {
            using var conn = new MySqlConnection(_conn);
            conn.Open();
            var query = $"SELECT 1 FROM {tableName} WHERE ";
            query += $"{columns} = @keyword";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@keyword", $"%{keyword}%");
            var result = cmd.ExecuteScalar();
            return result != null;
        }

        public T GetById(long id)
        {
            using var conn = new MySqlConnection(_conn);
            conn.Open();

            var cmd = new MySqlCommand($"SELECT * FROM {_tableName} WHERE id=@id", conn);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                using var rd = cmd.ExecuteReader();
                if (!rd.Read()) return null!;
                return MapWithJsonProperty(rd);
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Update(T entity)
        {
            using var conn = new MySqlConnection(_conn);
            conn.Open();

            var props = typeof(T).GetProperties()
                .Where(p => p.Name != "Id");

            var setClause = string.Join(",",
                props.Select(p => $"{p.Name.ToLower()}=@{p.Name}"));

            var cmd = new MySqlCommand($@"
                UPDATE {_tableName}
                SET {setClause}
                WHERE id=@Id
            ", conn);

            cmd.Parameters.AddWithValue("@Id", entity.Id);

            foreach (var prop in props)
            {
                cmd.Parameters.AddWithValue("@" + prop.Name,
                    prop.GetValue(entity) ?? DBNull.Value);
            }

            try
            {
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Delete(long id)
        {
            using var conn = new MySqlConnection(_conn);
            conn.Open();

            var cmd = new MySqlCommand(
                $"DELETE FROM {_tableName} WHERE id=@id", conn);

            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private T Map(MySqlDataReader rd)
        {
            var obj = new T();

            foreach (var prop in typeof(T).GetProperties())
            {
                if (!rd.HasColumn(prop.Name.ToLower())) continue;

                var value = rd[prop.Name.ToLower()];
                if (value == DBNull.Value) continue;

                prop.SetValue(obj, value);
            }

            return obj;
        }

        private T MapWithJsonProperty(MySqlDataReader rd)
        {
            try
            {
                var obj = new T();

                foreach (var prop in typeof(T).GetProperties())
                {
                    var attr = prop.GetCustomAttribute<JsonPropertyNameAttribute>();

                    var columnName = attr != null
                        ? attr.Name
                        : prop.Name;

                    if (!rd.HasColumn(columnName)) continue;

                    var value = rd[columnName];

                    if (value == DBNull.Value)
                    {
                        prop.SetValue(obj, null);
                        continue;
                    }

                    var targetType = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;

                    try
                    {
                        var safeValue = Convert.ChangeType(value, targetType);
                        prop.SetValue(obj, safeValue);
                    }
                    catch
                    {
                        Logger.Info($"Không thể chuyển đổi giá trị '{value}' sang kiểu '{targetType.Name}' cho thuộc tính '{prop.Name}'.");
                        continue;
                    }
                }

                return obj;
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}