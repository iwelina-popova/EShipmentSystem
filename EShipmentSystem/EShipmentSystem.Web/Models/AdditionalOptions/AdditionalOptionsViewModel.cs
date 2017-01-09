namespace EShipmentSystem.Web.Models.AdditionalOptions
{
    public class AdditionalOptionsViewModel
    {
        public int Id { get; set; }

        public decimal? DeclaredValue { get; set; }

        public decimal? CashOnDelivery { get; set; }

        public bool AdviceOnDelivery { get; set; }

        public bool BillOfGoodsAndReceipt { get; set; }

        public bool ReturnShipment { get; set; }

        public bool ReviewShipment { get; set; }
    }
}
