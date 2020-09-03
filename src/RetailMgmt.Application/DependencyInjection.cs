using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using RetailMgmt.Application.Services.OrganizationModule;
using RetailMgmt.Core.Services.OrganizationModule;
using System.Reflection;

namespace RetailMgmt.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<ICurrencyService, CurrencyService>();
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
