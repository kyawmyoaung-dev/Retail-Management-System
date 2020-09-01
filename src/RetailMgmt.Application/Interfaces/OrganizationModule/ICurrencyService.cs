using RetailMgmt.Core.Entities.OrganizationModule;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RetailMgmt.Application.Interfaces.OrganizationModule
{
    public interface ICurrencyService
    {
        Task<Currency> GetCurrencyByCodeName(string codeName);

        Task<IEnumerable<Currency>> GetAllCurrencyAsync();
    }
}
