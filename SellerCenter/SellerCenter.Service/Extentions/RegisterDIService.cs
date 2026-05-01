using Microsoft.Extensions.DependencyInjection;
using SellerCenter.Helper;
using System.Reflection;

namespace SellerCenter.Service.Extentions
{
    public static class RegisterDIService
    {
        public static IServiceCollection AddService(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();
            return DIHelper.RegisterDependencyInjection(services, assembly);
        }
    }
}