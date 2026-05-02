using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SellerCenter.Commons;
using SellerCenter.Forms;
using SellerCenter.Helpers;
using SellerCenter.Infrastructure;
using SellerCenter.Infrastructure.Configs;
using SellerCenter.Infrastructure.Configs.Model;
using SellerCenter.Infrastructure.Extensions;
using SellerCenter.Infrastructure.Implementation;
using SellerCenter.Service;
using SellerCenter.Service.DTO;
using SellerCenter.Service.Extentions;
using SellerCenter.Service.Implementation;
using System.Reflection;

namespace SellerCenter
{
    internal static class Program
    {
        public static IHost? AppHost;

        [STAThread]
        private static void Main()
        {
            AppHost = Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) =>
            {
                Logger.Init();
                services.Configure<ChatGPTConfig>(context.Configuration.GetSection("ChatGPTConfig"));
                services.Configure<DatabaseConfig>(context.Configuration.GetSection("DatabaseConfig"));
                services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
                services.AddScoped(typeof(IService<>), typeof(Service<>));
                RegisterDIInfrastructure.AddInfrastructure(services);
                RegisterDIService.AddService(services);
            })
            .Build();
            AppConfig.Init();
            ApplicationConfiguration.Initialize();
            Application.ThreadException += (sender, args) =>
            {
                Logger.Error(args.Exception);
                MessageBox.Show(args.Exception.Message, "Error");
            };

            AppDomain.CurrentDomain.UnhandledException += (sender, args) =>
            {
                var ex = args.ExceptionObject as Exception;
                MessageBox.Show(ex?.Message ?? "Unknown error", "Error");
                Logger.Error(ex?.Message!);
            };
            var loginForm = new frmLogin();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Form1());
            }
        }
    }
}