namespace EShipmentSystem.Service.Data
{
    using System;
    using System.Linq;

    using Contracts;
    using EShipmentSystem.Data.Models;
    using EShipmentSystem.Data.Repositories;

    public class AdditionalOptionsService : IAdditionalOptionsService
    {
        private readonly IRepository<AdditionalOptions> repo;

        public AdditionalOptionsService(IRepository<AdditionalOptions> repo)
        {
            this.repo = repo;
        }

        public void Create(AdditionalOptions options)
        {
            this.repo.Add(options);
            this.repo.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = this.GetById(id);
            this.repo.Delete(entity);
            this.repo.SaveChanges();
        }

        public IQueryable<AdditionalOptions> GetAll()
        {
            return this.repo.All();
        }

        public IQueryable<AdditionalOptions> GetAllWithDeleted()
        {
            return this.repo.AllWithDeleted();
        }

        public AdditionalOptions GetById(int id)
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
