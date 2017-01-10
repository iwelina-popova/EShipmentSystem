namespace EShipmentSystem.Services.Contracts
{
    using System.Linq;
    using Data.Models;

    public interface IReceiverService
    {
        IQueryable<Receiver> GetAll();

        IQueryable<Receiver> GetAllWithDeleted();

        Receiver GetById(int id);

        void Create(Receiver receiver);

        void Update();

        void Delete(int id);
    }
}
