namespace EShipmentSystem.Data.Models
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

    public class ApplicationUser : IdentityUser
    {
        public string Phone { get; set; }
        
        public string CompanyName { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public string Address { get; set; }

        public string Neighborhood { get; set; }

        public string ZipCode { get; set; }
        
        public ICollection<ShipmentData> ShipmentDatas { get; set; } = new List<ShipmentData>();
    }
}
