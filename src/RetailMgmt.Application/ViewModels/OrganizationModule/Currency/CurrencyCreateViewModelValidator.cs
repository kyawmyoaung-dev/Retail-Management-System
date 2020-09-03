using FluentValidation;

namespace RetailMgmt.Application.ViewModels.OrganizationModule.Currency
{
    public class CurrencyCreateViewModelValidator : AbstractValidator<CurrencyCreateViewModel>
    {
        public CurrencyCreateViewModelValidator()
        {
            RuleFor(m => m.Code).NotEmpty().WithMessage("Require Code !");
        }
    }
}
