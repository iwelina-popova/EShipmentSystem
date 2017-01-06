namespace EShipmentSystem.Service.Data
{
    using System.Linq;

    using Contracts;
    using EShipmentSystem.Data.Models;
    using EShipmentSystem.Data.Repositories;

    public class ReceiverSenderDataService : IReceiverSenderDataService
    {
        private readonly IRepository<ReceiverSenderData> repo;

        public ReceiverSenderDataService(IRepository<ReceiverSenderData> repo)
        {
            this.repo = repo;
        }

        public void Create(ReceiverSenderData data)
        {
            this.repo.Add(data);
            this.repo.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = this.GetById(id);
            this.repo.Delete(entity);
            this.repo.SaveChanges();
        }

        public IQueryable<ReceiverSenderData> GetAll()
        {
            return this.repo.All();
        }

        public IQueryable<ReceiverSenderData> GetAllWithDeleted()
        {
            return this.repo.AllWithDeleted();
        }

        public ReceiverSenderData GetById(int id)
        {
            return this.repo
                .All()
                .Where(e => e.Id == id)
                .FirstOrDefault();
        }

        public void Update()
        {
            this.repo.SaveChanges();
        }
    }
}
