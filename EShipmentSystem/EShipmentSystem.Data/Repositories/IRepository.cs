namespace EShipmentSystem.Data.Repositories
{
    using System.Linq;
    using Models.BaseEntities;

    public interface IRepository<TEntity>
        where TEntity : class, IAuditInfo
    {
        IQueryable<TEntity> All();

        IQueryable<TEntity> AllWithDeleted();

        void Add(TEntity entity);

        void Delete(TEntity entity);

        void SaveChanges();
    }
}
