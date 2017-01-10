namespace EShipmentSystem.Web.Models.Shipment
{
    using System.Collections.Generic;
    using AdditionalOptions;
    using Receiver;
    using User;

    public class ShipmentViewModel
    {
        public int Id { get; set; }

        public double Length { get; set; }

        public double Width { get; set; }

        public double Height { get; set; }

        public double Weight { get; set; }

        public UserVIewModel User { get; set; }

        public ReceiverViewModel Receiver { get; set; }

        public IEnumerable<AdditionalOptionsViewModel> Options { get; set; }
    }
}
