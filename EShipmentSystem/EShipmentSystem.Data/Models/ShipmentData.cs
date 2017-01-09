namespace EShipmentSystem.Data.Models
{
    using BaseEntities;
    
    public class ShipmentData : BaseEntity<int>
    {
        public ShipmentType Type { get; set; }

        public double Length { get; set; }

        public double Width { get; set; }

        public double Height { get; set; }

        public double Weight { get; set; }

        public int SenderId { get; set; }

        public ReceiverSenderData Sender { get; set; }

        public int ReceiverId { get; set; }

        public ReceiverSenderData Receiver { get; set; }

        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        public int AdditionalOptionsId { get; set; }

        public AdditionalOptions AdditionalOptions { get; set; }
    }
}
