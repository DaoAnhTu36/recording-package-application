using System.Data;

namespace SellerCenter.Helpers
{
    public static class DataHelper
    {
        public static AutoCompleteStringCollection ToAutoCompleteSource(DataTable dt, string columnName)
        {
            var source = new AutoCompleteStringCollection();

            var list = dt.AsEnumerable()
                .Where(r => r[columnName] != DBNull.Value)
                .Select(r => r[columnName].ToString())
                .Distinct()
                .ToArray();

            source.AddRange(list!);

            return source;
        }
    }
}