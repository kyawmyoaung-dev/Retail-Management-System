using Microsoft.Extensions.DependencyInjection;
using RetailMgmt.Application.Services.OrganizationModule;
using RetailMgmt.Core.Services.OrganizationModule;

namespace RetailMgmt.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<ICurrencyService, CurrencyService>();

            return services;
        }
    }
}
