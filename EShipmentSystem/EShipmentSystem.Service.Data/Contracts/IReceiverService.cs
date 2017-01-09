namespace EShipmentSystem.Service.Data.Contracts
{
    using System.Linq;
    using EShipmentSystem.Data.Models;

    public interface IReceiverService
    {
        IQueryable<Receiver> GetAll();

        IQueryable<Receiver> GetAllWithDeleted();

        Receiver GetById(int id);

        void Create(Receiver data);

        void Update();

        void Delete(int id);
    }
}
