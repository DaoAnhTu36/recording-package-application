using MySql.Data.MySqlClient;
using SellerCenter.Infrastructure.Extensions;
using SellerCenter.Infrastructure.Models;

namespace SellerCenter.Infrastructure.Implementation
{
    public class Repository<T> : IRepository<T> where T : class, IEntity, new()
    {
        private readonly string _conn;
        private readonly string _tableName;

        public Repository(string conn)
        {
            _conn = conn;
            _tableName = typeof(T).Name.Replace("Model", "").ToLower() + "s";
        }

        public long Create(T entity)
        {
            using var conn = new MySqlConnection(_conn);
            conn.Open();

            var props = typeof(T).GetProperties()
                .Where(p => p.Name != "Id");

            var columns = string.Join(",", props.Select(p => p.Name.ToLower()));
            var values = string.Join(",", props.Select(p => "@" + p.Name));

            var cmd = new MySqlCommand($@"
            INSERT INTO {_tableName} ({columns})
            VALUES ({values});
            SELECT LAST_INSERT_ID();
        ", conn);

            foreach (var prop in props)
            {
                cmd.Parameters.AddWithValue("@" + prop.Name,
                    prop.GetValue(entity) ?? DBNull.Value);
            }

            return Convert.ToInt64(cmd.ExecuteScalar());
        }

        public List<T> GetAll()
        {
            var list = new List<T>();

            using var conn = new MySqlConnection(_conn);
            conn.Open();

            var cmd = new MySqlCommand($"SELECT * FROM {_tableName}", conn);
            using var rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                list.Add(Map(rd));
            }

            return list;
        }

        public T GetById(long id)
        {
            using var conn = new MySqlConnection(_conn);
            conn.Open();

            var cmd = new MySqlCommand($"SELECT * FROM {_tableName} WHERE id=@id", conn);
            cmd.Parameters.AddWithValue("@id", id);

            using var rd = cmd.ExecuteReader();

            if (!rd.Read()) return null;

            return Map(rd);
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

            return cmd.ExecuteNonQuery() > 0;
        }

        public bool Delete(long id)
        {
            using var conn = new MySqlConnection(_conn);
            conn.Open();

            var cmd = new MySqlCommand(
                $"DELETE FROM {_tableName} WHERE id=@id", conn);

            cmd.Parameters.AddWithValue("@id", id);

            return cmd.ExecuteNonQuery() > 0;
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
    }
}