using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace SellerCenter.Helper
{
    public static class DIHelper
    {
        public static IServiceCollection RegisterDependencyInjection(this IServiceCollection services, Assembly assembly)
        {
            var types = assembly.GetTypes();
            foreach (var type in types)
            {
                if (!type.IsClass || type.IsAbstract)
                {
                    Logger.Info($"Skipping {type.FullName} because it is not a concrete class.");
                    continue;
                }

                if (!type.Name.EndsWith("Service") &&
                    !type.Name.EndsWith("Repository"))
                {
                    Logger.Info($"Skipping {type.FullName} because it does not end with 'Service' or 'Repository'."); continue;
                }
                foreach (var i in type.GetInterfaces())
                {
                    if (i.Name != $"I{type.Name}")
                    {
                        Logger.Info($"Skipping {type.FullName} because it does not implement an interface named I{type.Name}.");
                        continue;
                    }

                    if (services.Any(s => s.ServiceType == i)) continue;

                    services.AddScoped(i, type);
                }
            }

            return services;
        }
    }
}