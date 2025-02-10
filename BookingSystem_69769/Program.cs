using Domain;
using Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BookingSystem_69769
{
    internal static class Program
    {
        private static IServiceProvider _serviceProvider;

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();
            ConfigureServices(services);
            _serviceProvider = services.BuildServiceProvider();

            Application.Run(_serviceProvider.GetRequiredService<LoginForm>());
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            var basePath = Directory.GetCurrentDirectory();
            var devSettingsPath = Path.Combine(basePath, "appsettings.Development.json");

            var builder = new ConfigurationBuilder().SetBasePath(basePath);

            if (File.Exists(devSettingsPath))
            {
                builder.AddJsonFile("appsettings.Development.json", optional: false, reloadOnChange: true);
            }
            else
            {
                builder.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            }

            var configuration = builder.Build();

            services.AddSingleton<IConfiguration>(configuration);

            services.AddDomainServices();
            services.AddInfrastructureServices();

            services.AddTransient<LoginForm>();
            services.AddTransient<RegisterForm>();
        }
    }
}