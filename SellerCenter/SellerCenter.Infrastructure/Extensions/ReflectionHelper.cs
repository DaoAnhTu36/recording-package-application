using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace SellerCenter.Infrastructure.Extensions
{
    public static class ReflectionHelper
    {
        public static string GetTableName<T>()
        {
            var attr = typeof(T).GetCustomAttribute<TableAttribute>();
            return attr?.Name ?? typeof(T).Name.ToLower();
        }
    }
}