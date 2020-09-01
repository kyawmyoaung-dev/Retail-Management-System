using RetailMgmt.Core.Entities.OrganizationModule;
using RetailMgmt.Core.Interfaces.Base;
using System.Threading.Tasks;

namespace RetailMgmt.Core.Interfaces.OrganizationModule
{
    public interface ICurrencyRepository : IRepositoryBase<Currency>
    {
        Task<Currency> GetCurrencyByCodeName(string codeName);
    }
}
