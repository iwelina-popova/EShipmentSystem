namespace EShipmentSystem.Service.Data.Contracts
{
    using System.Linq;
    using EShipmentSystem.Data.Models;

    public interface IAdditionalOptionsService
    {
        IQueryable<AdditionalOptions> GetAll();

        IQueryable<AdditionalOptions> GetAllWithDeleted();

        AdditionalOptions GetById(int id);

        void Create(AdditionalOptions options);

        void Update();

        void Delete(int id);
    }
}
