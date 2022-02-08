using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Windows.Forms;

namespace DemoMVVM {
    internal static class Program {
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            IHost host = Host.CreateDefaultBuilder()
                .ConfigureServices(ConfigureServices)
                .Build();
            MainView mainView = host.Services.GetRequiredService<MainView>();
            Application.Run(mainView);
        }

        private static void ConfigureServices(HostBuilderContext context, IServiceCollection services) {
            services.AddTransient<MainView>();
            services.AddTransient<MainViewModel>();
        }
    }
}
