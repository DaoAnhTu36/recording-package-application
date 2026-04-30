using Microsoft.Extensions.Configuration;

namespace SellerCenter.Infrastructure.Configs
{
    public class AppConfig
    {
        private static IConfigurationRoot? _config;

        public static string? EnvironmentName { get; private set; }

        public static void Init()
        {
            var baseConfig = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            EnvironmentName = baseConfig["Environment"] ?? "Production";

            _config = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{EnvironmentName}.json", optional: true, reloadOnChange: true)
                .Build();
        }

        public static T Get<T>(string section)
        {
            return _config!.GetSection(section).Get<T>()!;
        }

        public static string GetValue(string key)
        {
            return _config![key]!;
        }
    }
}