using RetailMgmt.Core.Entities.Base;

namespace RetailMgmt.Core.Entities.OrganizationModule
{
    public class Currency : EntityBase
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public bool IsHomeCurrency { get;set;}
    }
}
