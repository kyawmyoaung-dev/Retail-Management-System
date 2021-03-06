﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RetailMgmt.Core.Interfaces.Base;
using RetailMgmt.Core.Repositories.OrganizationModule;
using RetailMgmt.Infrastructure.Data;
using RetailMgmt.Infrastructure.Repositories.OrganizationModule;
using RetailMgmt.Infrastructure.Repository.Base;

namespace RetailMgmt.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddRetailDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<RetailDbContext>(c =>
                c.UseSqlServer(configuration.GetConnectionString("RetailDBCS")), ServiceLifetime.Singleton);

            return services;
        }

        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepositoryBase<>), typeof(EfRepositoryBase<>));
            services.AddScoped<ICurrencyRepository, CurrencyRepository>();


            return services;
        }
    }
}
