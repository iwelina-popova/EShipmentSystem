namespace EShipmentSystem.Web.Views.Shipment
{
    using System.Collections.Generic;
    using Models.AdditionalOptions;
    using Models.Receiver;

    public class ShipmentViewModel
    {
        public int Id { get; set; }

        public double Length { get; set; }

        public double Width { get; set; }

        public double Height { get; set; }

        public double Weight { get; set; }

        public UserViewModel User { get; set; }

        public ReceiverViewModel Receiver { get; set; }

        public IEnumerable<AdditionalOptionsViewModel> Options { get; set; }
    }
}
