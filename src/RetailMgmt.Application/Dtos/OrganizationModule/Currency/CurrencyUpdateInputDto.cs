using System;

namespace RetailMgmt.Application.Dtos.OrganizationModule.Currency
{
    public class CurrencyUpdateInputDto
    {
        public string Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public bool IsHomeCurrency { get; set; }
        public string UpdatedUserId { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
