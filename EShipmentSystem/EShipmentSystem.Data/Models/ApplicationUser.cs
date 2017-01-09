namespace EShipmentSystem.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

    public class ApplicationUser : IdentityUser
    {
        [Required]
        [MaxLength(20)]
        public string Phone { get; set; }
        
        public string CompanyName { get; set; }

        [Required]
        [MaxLength(50)]
        public string Country { get; set; }

        [Required]
        [MaxLength(50)]
        public string City { get; set; }

        [Required]
        [MaxLength(150)]
        public string Address { get; set; }

        [MaxLength(150)]
        public string Neighborhood { get; set; }

        [Required]
        [MaxLength(50)]
        public string ZipCode { get; set; }
        
        public ICollection<ShipmentData> ShipmentDatas { get; set; } = new List<ShipmentData>();
    }
}
