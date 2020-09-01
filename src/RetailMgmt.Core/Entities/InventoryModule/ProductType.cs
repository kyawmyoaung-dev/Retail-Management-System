using RetailMgmt.Core.Entities.Base;

namespace RetailMgmt.Core.Entities.InventoryModule
{
    public class ProductType : EntityBase
    {
        public string Code { get; set; }
        public string Description { get; set; }
    }
}
