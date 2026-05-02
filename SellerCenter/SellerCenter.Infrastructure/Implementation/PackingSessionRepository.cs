using Microsoft.Extensions.Options;
using MySql.Data.MySqlClient;
using SellerCenter.Infrastructure.Configs.Model;
using SellerCenter.Infrastructure.Models;
using System.Data;

namespace SellerCenter.Infrastructure.Implementation
{
    public class PackingSessionRepository : Repository<PackingSessionModel>, IPackingSessionRepository
    {
        private readonly string _conn;

        public PackingSessionRepository(IOptions<AppSettingConfig> dbConfig) : base(dbConfig.Value.DatabaseConfig!.ConnectionString!)
        {
            _conn = dbConfig.Value.DatabaseConfig!.ConnectionString!;
        }

        public DataTable GetAllSessions()
        {
            using var conn = new MySqlConnection(_conn);
            conn.Open();
            using var cmd = new MySqlCommand(@"SELECT id, barcode, local_path, youtube_url, created_at FROM packing_sessions", conn);
            using var adapter = new MySqlDataAdapter(cmd);
            var dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public void InsertSession(string barcode, string localPath)
        {
            using var conn = new MySqlConnection(_conn);
            conn.Open();
            using var cmd = new MySqlCommand("INSERT INTO packing_sessions (barcode, local_path, created_at) VALUES (@barcode, @localPath, @createdAt)", conn);
            cmd.Parameters.AddWithValue("@barcode", barcode);
            cmd.Parameters.AddWithValue("@localPath", localPath);
            cmd.Parameters.AddWithValue("@createdAt", DateTime.Now);
            cmd.ExecuteNonQuery();
        }

        public void UpdateSession(string barcode, string youtubeUrl)
        {
            using var conn = new MySqlConnection(_conn);
            conn.Open();
            using var cmd = new MySqlCommand("UPDATE packing_sessions SET youtube_url = @youtubeUrl WHERE barcode = @barcode", conn);
            cmd.Parameters.AddWithValue("@barcode", barcode);
            cmd.Parameters.AddWithValue("@youtubeUrl", youtubeUrl);
            cmd.ExecuteNonQuery();
        }

        public bool IsBarcodeExists(string barcode)
        {
            using var conn = new MySqlConnection(_conn);
            conn.Open();
            string query = "SELECT COUNT(barcode) FROM packing_sessions WHERE barcode = @barcode";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@barcode", barcode);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            return count > 0;
        }

        public async Task<DataTable> GetHistoryRecordByBarcode(string? barcode, DateTime? fromDate, DateTime? toDate)
        {
            var dt = new DataTable();
            using var conn = new MySqlConnection(_conn);
            await conn.OpenAsync();
            var sql = @"SELECT id, barcode, local_path, youtube_url, created_at FROM packing_sessions WHERE 1=1";
            using var cmd = new MySqlCommand();
            cmd.Connection = conn;

            if (!string.IsNullOrWhiteSpace(barcode) && !string.IsNullOrEmpty(barcode))
            {
                sql += " AND barcode COLLATE utf8mb4_general_ci LIKE @barcode";
                cmd.Parameters.AddWithValue("@barcode", "%" + barcode.Trim() + "%");
            }

            if (fromDate.HasValue)
            {
                sql += " AND created_at >= @fromDate";
                cmd.Parameters.AddWithValue("@fromDate", fromDate.Value.Date);
            }

            if (toDate.HasValue)
            {
                sql += " AND created_at < @toDate";
                cmd.Parameters.AddWithValue("@toDate", toDate.Value.Date.AddDays(1));
            }

            sql += " ORDER BY created_at DESC";
            cmd.CommandText = sql;
            using var reader = await cmd.ExecuteReaderAsync();
            dt.Load(reader);
            return dt;
        }
    }
}