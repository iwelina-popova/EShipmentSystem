namespace EShipmentSystem.Services
{
    using System.Linq;

    using Contracts;
    using Data.Models;
    using Data.Repositories;

    public class ShipmentDataService : IShipmentDataService
    {
        private readonly IRepository<ShipmentData> repo;

        public ShipmentDataService(IRepository<ShipmentData> repo)
        {
            this.repo = repo;
        }

        public void Create(ShipmentData shipment)
        {
            this.repo.Add(shipment);
            this.repo.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = this.GetById(id);
            this.repo.Delete(entity);
            this.repo.SaveChanges();
        }

        public IQueryable<ShipmentData> GetAll()
        {
            return this.repo.All();
        }

        public IQueryable<ShipmentData> GetAllWithDeleted()
        {
            return this.repo.AllWithDeleted();
        }

        public ShipmentData GetById(int id)
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
