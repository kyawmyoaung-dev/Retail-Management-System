using RetailMgmt.Core.Entities.Base;
using System;

namespace RetailMgmt.Core.Entities.OrganizationModule
{
    public class FinancialYear : EntityBase
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsCurrentYear { get; set; }
    }
}
