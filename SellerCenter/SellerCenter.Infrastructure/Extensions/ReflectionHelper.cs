using System.ComponentModel.DataAnnotations.Schema;
using System.Linq.Expressions;
using System.Reflection;
using System.Text.Json.Serialization;

namespace SellerCenter.Infrastructure.Extensions
{
    public static class ReflectionHelper
    {
        public static string GetTableName<T>()
        {
            var attr = typeof(T).GetCustomAttribute<TableAttribute>();
            return attr?.Name ?? typeof(T).Name.ToLower();
        }

        public static string GetJsonPropertyName(PropertyInfo prop)
        {
            var attr = prop.GetCustomAttribute<JsonPropertyNameAttribute>();
            return attr?.Name ?? prop.Name;
        }

        public static string GetColumnName<T>(Expression<Func<T, object>> expression)
        {
            MemberExpression member;

            if (expression.Body is UnaryExpression unary)
                member = unary.Operand as MemberExpression;
            else
                member = expression.Body as MemberExpression;

            if (member == null)
                throw new Exception("Invalid expression");

            var prop = member.Member as PropertyInfo;

            var attr = prop.GetCustomAttribute<JsonPropertyNameAttribute>();

            return attr?.Name ?? prop.Name;
        }
    }
}