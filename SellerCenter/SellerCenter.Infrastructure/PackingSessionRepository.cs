using MySql.Data.MySqlClient;
using System.Data;

namespace SellerCenter.Infrastructure
{
    public class PackingSessionRepository
    {
        private DatabaseRepository _db;

        public PackingSessionRepository()
        {
            _db = new DatabaseRepository();
        }

        public DataTable GetAllSessions()
        {
            using var conn = _db.GetConnection();
            conn.Open();
            using var cmd = new MySqlCommand("SELECT barcode, video_path, created_at FROM packing_sessions", conn);
            using var adapter = new MySqlDataAdapter(cmd);
            var dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public void InsertSession(string barcode, string videoPath)
        {
            using var conn = _db.GetConnection();
            conn.Open();
            using var cmd = new MySqlCommand("INSERT INTO packing_sessions (barcode, video_path, created_at) VALUES (@barcode, @videoPath, @createdAt)", conn);
            cmd.Parameters.AddWithValue("@barcode", barcode);
            cmd.Parameters.AddWithValue("@videoPath", videoPath);
            cmd.Parameters.AddWithValue("@createdAt", DateTime.Now);
            cmd.ExecuteNonQuery();
        }

        public bool IsBarcodeExists(string barcode)
        {
            using var conn = _db.GetConnection();
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

            using var conn = _db.GetConnection();
            await conn.OpenAsync();

            var sql = @"SELECT barcode, video_path, created_at FROM packing_sessions WHERE 1=1";

            using var cmd = new MySqlCommand();
            cmd.Connection = conn;

            if (!string.IsNullOrWhiteSpace(barcode))
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