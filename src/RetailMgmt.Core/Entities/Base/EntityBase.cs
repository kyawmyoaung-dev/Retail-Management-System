using System;

namespace RetailMgmt.Core.Entities.Base
{
    public abstract class EntityBase
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string CreatedUserId { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string UpdatedUserId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
