
using RetailMgmt.Application.Dtos.OrganizationModule.Currency;
using RetailMgmt.Application.Interfaces.OrganizationModule.Currency;
using RetailMgmt.Core.Entities.OrganizationModule;
using RetailMgmt.Core.Repositories.OrganizationModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetailMgmt.Application.Services.OrganizationModule
{
    public class CurrencyService : ICurrencyService
    {
        private readonly ICurrencyRepository _currencyRepository;

        public CurrencyService(ICurrencyRepository currencyRepository)
        {
            _currencyRepository = currencyRepository ?? throw new ArgumentNullException(nameof(ICurrencyRepository));
        }

        public async Task CreateAsync(CurrencyCreateInputDto input)
        {
            Currency createCurrency = new Currency()
            {
                Code = input.Code,
                Description = input.Description,
                IsHomeCurrency = input.IsHomeCurrency,
                CreatedDate = input.CreatedDate,
                CreatedUserId = input.CreatedUserId
                
            };

            await _currencyRepository.AddAsync(createCurrency);
            await _currencyRepository.SaveChangesAsync();
        }

        public async Task DeleteAsync(CurrencyDeleteInputDto input)
        {
            var deleteCurrency = await _currencyRepository.GetByIdAsync(input.Id);

            deleteCurrency.IsActive = false;
            deleteCurrency.UpdatedDate = input.UpdatedDate;
            deleteCurrency.UpdatedUserId = input.UpdatedUserId;

            _currencyRepository.Update(deleteCurrency);

            await _currencyRepository.SaveChangesAsync();
        }

        public async Task DisposeAsync()
        {
            await _currencyRepository.DisposeAsync();
        }

        public async Task<List<CurrencyListItemDto>> GetPagedListAsync(CurrencyListInputDto input)
        {
            var list = await _currencyRepository.GetPagedListAsync(x => x.IsActive == true);

            return list.Select(x => new CurrencyListItemDto { Code = x.Code, Description = x.Description, Id = x.Id }).ToList();

        }

        public async Task UpdateAsync(CurrencyUpdateInputDto input)
        {
            var updateCurrency = await _currencyRepository.GetByIdAsync(input.Id);
            updateCurrency.Code = input.Code;
            updateCurrency.Description = input.Description;
            updateCurrency.IsHomeCurrency = input.IsHomeCurrency;
            updateCurrency.UpdatedDate = input.UpdatedDate;
            updateCurrency.UpdatedUserId = input.UpdatedUserId;

            _currencyRepository.Update(updateCurrency);

            await _currencyRepository.SaveChangesAsync();
        }
    }
}
