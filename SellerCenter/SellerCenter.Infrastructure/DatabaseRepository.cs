using MySql.Data.MySqlClient;

namespace SellerCenter.Infrastructure
{
    public class DatabaseRepository
    {
        private string connStr = "Server=localhost;Database=seller_center;Uid=root;Pwd=123456;";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connStr);
        }
    }
}