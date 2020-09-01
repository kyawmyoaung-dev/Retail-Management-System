using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RetailMgmt.Infrastructure.Data;
using RetailMgmt.Infrastructure.Data.SeedData.OrganizationModule;

namespace RetailMgmt.WebMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            CreateAndSeedDatabase(host);
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        private static void CreateAndSeedDatabase(IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var aspnetRunContext = services.GetRequiredService<RetailDbContext>();
                CurrencySeedData.SeedAsync(aspnetRunContext).Wait();
            }
        }
    }
}
