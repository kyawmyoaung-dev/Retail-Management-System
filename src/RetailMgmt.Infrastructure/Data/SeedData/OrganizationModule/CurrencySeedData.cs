using RetailMgmt.Core.Entities.OrganizationModule;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetailMgmt.Infrastructure.Data.SeedData.OrganizationModule
{
    public class CurrencySeedData
    {
        public static async Task  SeedAsync(RetailDbContext dbContext)
        {
            dbContext.Database.EnsureCreated();

            if(!dbContext.Currencies.Any())
            {
                dbContext.Currencies.AddRange(GerPreconfiguredCurrency());
                await dbContext.SaveChangesAsync();
            }
        }

        private static List<Currency> GerPreconfiguredCurrency()
        { 
            return new List<Currency>()
            {
                new Currency(){ Code = "US", Description = "United States" },
                new Currency(){ Code = "MM", Description = "Myanmar" }

            };
        }
    }
}
