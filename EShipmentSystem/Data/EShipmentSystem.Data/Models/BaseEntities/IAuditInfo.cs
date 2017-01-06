namespace EShipmentSystem.Data.Models.BaseEntities
{
    using System;

    public interface IAuditInfo
    {
        DateTime CreatedOn { get; set; }

        string CreatedById { get; set; }

        DateTime? ModifiedOn { get; set; }

        string ModifiedById { get; set; }

        bool IsDeleted { get; set; }

        DateTime? DeletedOn { get; set; }

        string DeletedById { get; set; }
    }
}
