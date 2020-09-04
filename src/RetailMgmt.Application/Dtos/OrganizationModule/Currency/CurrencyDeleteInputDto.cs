using System;
using System.Collections.Generic;
using System.Text;

namespace RetailMgmt.Application.Dtos.OrganizationModule.Currency
{
    public class CurrencyDeleteInputDto
    {
        public string Id { get; set; }
        public string UpdatedUserId { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
