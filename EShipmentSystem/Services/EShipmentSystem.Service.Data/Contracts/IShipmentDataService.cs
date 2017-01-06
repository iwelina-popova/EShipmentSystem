namespace EShipmentSystem.Service.Data.Contracts
{
    using System.Linq;
    using EShipmentSystem.Data.Models;

    public interface IShipmentDataService
    {
        IQueryable<ShipmentData> GetAll();

        IQueryable<ShipmentData> GetAllWithDeleted();

        ShipmentData GetById(int id);

        void Create(ShipmentData shipment);

        void Update();

        void Delete(int id);
    }
}
