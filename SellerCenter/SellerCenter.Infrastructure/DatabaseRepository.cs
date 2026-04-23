using MySql.Data.MySqlClient;

namespace SellerCenter.Infrastructure
{
    public class DatabaseRepository
    {
        private string connStr = "Server=localhost;Database=package_recording_db;Uid=root;Pwd=123456;";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connStr);
        }
    }
}