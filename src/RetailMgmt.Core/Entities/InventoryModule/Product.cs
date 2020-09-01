using RetailMgmt.Core.Entities.Base;
using RetailMgmt.Core.Entities.OrganizationModule;

namespace RetailMgmt.Core.Entities.InventoryModule
{
    public class Product : EntityBase
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal BuyingPrice { get; set; }
        public decimal SellingPrice { get; set; }
        public int Quantity { get; set; }
        public string CurrencyId { get; set; }
        public virtual Currency Currency { get; set; }

        public string CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public string ProductTypeId { get; set; }
        public virtual ProductType ProductType { get; set; }

        public string ProductGroupId { get; set; }
        public virtual ProductGroup ProductGroup { get; set; }

        public string FinancialYearId { get; set; }
        public virtual FinancialYear FinancialYear { get; set; }

    }
}
