using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RetailMgmt.Infrastructure.Data;

namespace RetailMgmt.WebMVC.Extension
{
    public static class RetailDbContextExtension
    {
        public static IServiceCollection AddRetailDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<RetailDbContext>(c =>
                c.UseSqlServer(configuration.GetConnectionString("RetailDBCS")), ServiceLifetime.Singleton);

            return services;
        }
    }
}
