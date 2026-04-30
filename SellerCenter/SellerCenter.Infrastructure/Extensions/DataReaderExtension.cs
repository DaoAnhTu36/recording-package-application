using MySql.Data.MySqlClient;

namespace SellerCenter.Infrastructure.Extensions
{
    public static class DataReaderExtension
    {
        public static bool HasColumn(this MySqlDataReader rd, string column)
        {
            for (int i = 0; i < rd.FieldCount; i++)
            {
                if (rd.GetName(i).Equals(column, StringComparison.OrdinalIgnoreCase))
                    return true;
            }
            return false;
        }
    }
}