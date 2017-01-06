namespace EShipmentSystem.Data.Models
{
    using BaseEntities;

    public class ReceiverSenderData : BaseEntity<int>
    {
        public string Name { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public string Address { get; set; }

        public string Neighborhood { get; set; }

        public string ZipCode { get; set; }

        public string OptionalInfo { get; set; }
    }
}
