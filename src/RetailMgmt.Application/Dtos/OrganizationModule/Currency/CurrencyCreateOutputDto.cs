namespace RetailMgmt.Application.Dtos.OrganizationModule.Currency
{
    public class CurrencyCreateOutputDto
    {
        public string Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public bool IsHomeCurrency { get; set; }
    }
}
