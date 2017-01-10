﻿namespace EShipmentSystem.Data.Models.BaseEntities
{
    using System;

    public class AuditInfo : IAuditInfo
    {
        public DateTime CreatedOn { get; set; }

        public DateTime? DeletedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? ModifiedOn { get; set; }
    }
}
