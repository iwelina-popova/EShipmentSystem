namespace EShipmentSystem.Data.Models.BaseEntities
{
    using System.ComponentModel.DataAnnotations;

    public class BaseEntity<TId> : AuditInfo
    {
        [Key]
        public TId Id { get; set; }
    }
}
