using MySql.Data.MySqlClient;
using PackagingRecordVideoApplication.Helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using ZXing.QrCode.Internal;

namespace PackagingRecordVideoApplication.Infrastructure
{
    public class PackingSessionRepository
    {
        private DbHelper _db;

        public PackingSessionRepository()
        {
            _db = new DbHelper();
        }

        public DataTable GetAllSessions()
        {
            using var conn = _db.GetConnection();
            conn.Open();
            using var cmd = new MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM packing_sessions", conn);
            using var adapter = new MySql.Data.MySqlClient.MySqlDataAdapter(cmd);
            var dt = new DataTable();
            adapter.Fill(dt);
            conn.Dispose();
            return dt;
        }

        public void InsertSession(string barcode, string videoPath)
        {
            using var conn = _db.GetConnection();
            conn.Open();
            using var cmd = new MySql.Data.MySqlClient.MySqlCommand("INSERT INTO packing_sessions (barcode, video_path, created_at) VALUES (@barcode, @videoPath, @createdAt)", conn);
            cmd.Parameters.AddWithValue("@barcode", barcode);
            cmd.Parameters.AddWithValue("@videoPath", videoPath);
            cmd.Parameters.AddWithValue("@createdAt", DateTime.Now);
            cmd.ExecuteNonQuery();
        }

        public bool IsBarcodeExists(string barcode)
        {
            using var conn = _db.GetConnection();
            conn.Open();
            string query = "SELECT COUNT(*) FROM packing_sessions WHERE barcode = @barcode";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@barcode", barcode);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            return count > 0;
        }
    }
}