using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace SellerCenter.Helper
{
    public static class EntityHelper
    {
        public static string GetTableName<T>()
        {
            var type = typeof(T);

            var attr = type.GetCustomAttribute<TableAttribute>();

            if (attr != null)
                return attr.Name;

            return type.Name;
        }
    }
}