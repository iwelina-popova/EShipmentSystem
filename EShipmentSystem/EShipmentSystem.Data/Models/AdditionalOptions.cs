namespace EShipmentSystem.Data.Models
{
    using BaseEntities;

    public class AdditionalOptions : BaseEntity<int>
    {
        public decimal? DeclaredValue { get; set; }

        public decimal? CashOnDelivery { get; set; }

        public bool AdviceOnDelivery { get; set; }

        public bool BillOfGoodsAndReceipt { get; set; }

        public bool ReturnShipment { get; set; }

        public bool ReviewShipment { get; set; }
    }
}
