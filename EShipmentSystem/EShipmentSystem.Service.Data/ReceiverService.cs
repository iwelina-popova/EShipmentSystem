namespace EShipmentSystem.Service.Data
{
    using System.Linq;

    using Contracts;
    using EShipmentSystem.Data.Models;
    using EShipmentSystem.Data.Repositories;

    public class ReceiverService : IReceiverService
    {
        private readonly IRepository<Receiver> repo;

        public ReceiverService(IRepository<Receiver> repo)
        {
            this.repo = repo;
        }

        public void Create(Receiver data)
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

        public IQueryable<Receiver> GetAll()
        {
            return this.repo.All();
        }

        public IQueryable<Receiver> GetAllWithDeleted()
        {
            return this.repo.AllWithDeleted();
        }

        public Receiver GetById(int id)
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
