namespace EShipmentSystem.Data.Models
{
    using System.Collections.Generic;
    using BaseEntities;

    public class AdditionalOptions : BaseEntity<int>
    {
        public decimal? DeclaredValue { get; set; }

        public decimal? CashOnDelivery { get; set; }

        public bool AdviceOnDelivery { get; set; }

        public bool BillOfGoodsAndReceipt { get; set; }

        public bool ReturnShipment { get; set; }

        public bool ReviewShipment { get; set; }

        public ICollection<ShipmentData> ShipmentDatas { get; set; } = new List<ShipmentData>();

    }
}
