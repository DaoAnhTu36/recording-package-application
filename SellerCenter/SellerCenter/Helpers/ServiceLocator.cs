using Microsoft.Extensions.DependencyInjection;

namespace SellerCenter.Helpers
{
    public static class ServiceLocator
    {
        public static T Get<T>() where T : notnull
        {
            return Program.AppHost!.Services.GetRequiredService<T>();
        }
    }
}