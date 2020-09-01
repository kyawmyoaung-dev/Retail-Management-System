using RetailMgmt.Application.Interfaces.OrganizationModule;
using RetailMgmt.Core.Entities.OrganizationModule;
using RetailMgmt.Core.Interfaces.OrganizationModule;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace RetailMgmt.Application.Services.OrganizationModule
{
    public class CurrencyService : ICurrencyService
    {
        private readonly ICurrencyRepository _currencyRepository;

        public CurrencyService(ICurrencyRepository currencyRepository)
        {
            _currencyRepository = currencyRepository ?? throw new ArgumentNullException(nameof(ICurrencyRepository));
        }

        public async Task<IEnumerable<Currency>> GetAllCurrencyAsync()
        {
            return await _currencyRepository.GetAllAsync();
        }

        public async Task<Currency> GetCurrencyByCodeName(string codeName)
        {
            return await _currencyRepository.GetCurrencyByCodeName(codeName);
        }
    }
}
