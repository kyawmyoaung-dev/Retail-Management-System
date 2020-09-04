using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using RetailMgmt.Application.Interfaces.OrganizationModule.Currency;
using RetailMgmt.Application.Services.OrganizationModule;
using System.Reflection;

namespace RetailMgmt.Application
{
    /// <summary>
    /// Developer : Kyaw Myo Aung
    /// DI class for all application services
    /// </summary>
    public static class DependencyInjection
    {
        /// <summary>
        /// IServiceColection Extension Method
        /// </summary>
        /// <param name="services">IServiceColection Extension</param>
        /// <returns></returns>
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<ICurrencyService, CurrencyService>();
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
