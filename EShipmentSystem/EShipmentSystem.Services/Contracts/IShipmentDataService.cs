namespace EShipmentSystem.Services.Contracts
{
    using System.Linq;
    using Data.Models;

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
