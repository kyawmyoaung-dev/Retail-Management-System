using Microsoft.EntityFrameworkCore;
using RetailMgmt.Core.Entities.OrganizationModule;
using RetailMgmt.Core.Interfaces.OrganizationModule;
using RetailMgmt.Infrastructure.Data;
using RetailMgmt.Infrastructure.Repository.Base;
using System.Threading.Tasks;

namespace RetailMgmt.Infrastructure.Repository.OrganizationModule
{
    public class CurrencyRepository : EfRepositoryBase<Currency>, ICurrencyRepository
    {

        public CurrencyRepository(RetailDbContext dbContext) : base(dbContext) { }

        public async Task<Currency> GetCurrencyByCodeName(string codeName)
        {
            return await _dbContext.Currencies.FirstOrDefaultAsync(x => x.Code == codeName);
        }
    }
}
