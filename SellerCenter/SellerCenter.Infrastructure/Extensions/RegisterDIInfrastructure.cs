using Microsoft.Extensions.DependencyInjection;
using SellerCenter.Helper;
using System.Reflection;

namespace SellerCenter.Infrastructure.Extensions
{
    public static class RegisterDIInfrastructure
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();
            return DIHelper.RegisterDependencyInjection(services, assembly);
        }
    }
}