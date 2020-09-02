using Microsoft.Extensions.DependencyInjection;
using RetailMgmt.Application.Interfaces.OrganizationModule;
using RetailMgmt.Application.Services.OrganizationModule;

namespace RetailMgmt.WebMVC.Extension
{
    public static class ApplicationServicesExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<ICurrencyService, CurrencyService>();

            return services;
        }
    }
}
