namespace EShipmentSystem.Service.Data.Contracts
{
    using System.Linq;
    using EShipmentSystem.Data.Models;

    public interface IReceiverSenderDataService
    {
        IQueryable<ReceiverSenderData> GetAll();

        IQueryable<ReceiverSenderData> GetAllWithDeleted();

        ReceiverSenderData GetById(int id);

        void Create(ReceiverSenderData data);

        void Update();

        void Delete(int id);
    }
}
