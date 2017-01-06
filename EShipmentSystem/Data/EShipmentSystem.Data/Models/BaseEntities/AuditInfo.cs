namespace EShipmentSystem.Data.Models.BaseEntities
{
    using System;

    public abstract class AuditInfo : IAuditInfo
    {
        public string CreatedById { get; set; }

        public DateTime CreatedOn { get; set; }

        public string DeletedById { get; set; }

        public DateTime? DeletedOn { get; set; }

        public bool IsDeleted { get; set; }

        public string ModifiedById { get; set; }

        public DateTime? ModifiedOn { get; set; }
    }
}
