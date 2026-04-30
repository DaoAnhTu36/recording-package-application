using Microsoft.Extensions.DependencyInjection;
using SellerCenter.Helper;
using System.Reflection;

namespace SellerCenter.Helpers
{
    public static class DIHelper
    {
        public static IServiceCollection AddAutoDI(
            this IServiceCollection services,
            Assembly assembly,
            Func<Type, bool>? filter = null)
        {
            var types = assembly.GetTypes();

            foreach (var type in types)
            {
                if (!type.IsClass || type.IsAbstract) continue;

                if (filter != null && !filter(type)) continue;

                var interfaces = type.GetInterfaces();

                foreach (var i in interfaces)
                {
                    if (i.Name != $"I{type.Name}") continue;

                    if (services.Any(x => x.ServiceType == i)) continue;

                    if (type.GetCustomAttribute<SingletonAttribute>() != null)
                        services.AddSingleton(i, type);
                    else if (type.GetCustomAttribute<TransientAttribute>() != null)
                        services.AddTransient(i, type);
                    else
                        services.AddScoped(i, type);
                }
            }

            return services;
        }
    }
}