using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SellerCenter.Commons;
using SellerCenter.Forms;
using SellerCenter.Helpers;
using SellerCenter.Infrastructure;
using SellerCenter.Infrastructure.Implementation;
using SellerCenter.Service;
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
                services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
                services.AddScoped(typeof(IService<>), typeof(Service<>));
                services.AddAutoDI(
                    Assembly.GetExecutingAssembly(),
                    type => type.Name.EndsWith("Service")
                         || type.Name.EndsWith("Repository")
                );
            })
            .Build();
            Logger.Init();
            AppConfig.Init();
            ApplicationConfiguration.Initialize();
            var loginForm = new frmLogin();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Form1());
            }
            Application.ThreadException += (sender, args) =>
            {
                Logger.Error(args.Exception);
            };

            AppDomain.CurrentDomain.UnhandledException += (sender, args) =>
            {
                Logger.Error(args.ExceptionObject as Exception);
            };
        }
    }
}