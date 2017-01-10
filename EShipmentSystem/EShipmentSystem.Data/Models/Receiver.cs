namespace EShipmentSystem.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using BaseEntities;

    public class Receiver : BaseEntity<int>
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string Phone { get; set; }

        [MaxLength(100)]
        public string Email { get; set; }

        [Required]
        [MaxLength(100)]
        public string Country { get; set; }

        [Required]
        [MaxLength(100)]
        public string City { get; set; }

        [Required]
        [MaxLength(150)]
        public string Address { get; set; }

        [MaxLength(150)]
        public string Neighborhood { get; set; }

        [Required]
        [MaxLength(50)]
        public string ZipCode { get; set; }

        public string OptionalInfo { get; set; }

        public ICollection<ShipmentData> ShipmentDatas { get; set; } = new List<ShipmentData>();
    }
}
