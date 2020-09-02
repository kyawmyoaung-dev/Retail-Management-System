using Microsoft.Extensions.DependencyInjection;
using RetailMgmt.Core.Interfaces.Base;
using RetailMgmt.Core.Interfaces.OrganizationModule;
using RetailMgmt.Infrastructure.Repository.Base;
using RetailMgmt.Infrastructure.Repository.OrganizationModule;

namespace RetailMgmt.WebMVC.Extension
{
    public static class InfrastructureExtensions
    {
        public static IServiceCollection AddInfrastructureRepository(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepositoryBase<>), typeof(EfRepositoryBase<>));
            services.AddScoped<ICurrencyRepository, CurrencyRepository>();


            return services;
        }
    }
}
