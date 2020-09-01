using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RetailMgmt.Application.Interfaces.OrganizationModule;
using RetailMgmt.Application.Services.OrganizationModule;
using RetailMgmt.Core.Interfaces.Base;
using RetailMgmt.Core.Interfaces.OrganizationModule;
using RetailMgmt.Infrastructure.Data;
using RetailMgmt.Infrastructure.Repository.Base;
using RetailMgmt.Infrastructure.Repository.OrganizationModule;


namespace RetailMgmt.WebMVC.Extension
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRetailDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<RetailDbContext>(c =>
                c.UseSqlServer(configuration.GetConnectionString("RetailDBCS")), ServiceLifetime.Singleton);

            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepositoryBase<>), typeof(EfRepositoryBase<>));
            services.AddScoped<ICurrencyRepository, CurrencyRepository>();
            services.AddScoped<ICurrencyService, CurrencyService>();

            return services;
        }
    }
}
