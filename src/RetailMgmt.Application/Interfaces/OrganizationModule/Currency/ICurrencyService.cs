using RetailMgmt.Application.Dtos.OrganizationModule.Currency;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RetailMgmt.Application.Interfaces.OrganizationModule.Currency
{
    public interface ICurrencyService
    {
        Task<List<CurrencyListItemDto>> GetPagedListAsync(CurrencyListInputDto input);
        Task CreateAsync(CurrencyCreateInputDto input);

        Task UpdateAsync(CurrencyUpdateInputDto input);

        Task DeleteAsync(CurrencyDeleteInputDto input);

        Task DisposeAsync();
    }
}
