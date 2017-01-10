namespace EShipmentSystem.Data.Repositories
{
    using System;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;

    using Models.BaseEntities;

    public class Repository<TEntity> : IRepository<TEntity>
        where TEntity : class, IAuditInfo
    {
        public Repository(EShipmentSystemDbContext context)
        {
            if (context == null)
            {
                throw new ArgumentException("An instance of DbContext is required to use this repository.", nameof(context));
            }

            this.Context = context;
            this.DbSet = this.Context.Set<TEntity>();
        }

        public DbContext Context { get; }

        public DbSet<TEntity> DbSet { get; }

        public void Add(TEntity entity)
        {
            this.DbSet.Add(entity);
        }

        public IQueryable<TEntity> All()
        {
            return this.DbSet.Where(x => !x.IsDeleted);
        }

        public IQueryable<TEntity> AllWithDeleted()
        {
            return this.DbSet;
        }

        public void Delete(TEntity entity)
        {
            entity.IsDeleted = true;
            entity.DeletedOn = DateTime.UtcNow;
        }

        public void SaveChanges()
        {
            this.Context.SaveChanges();
        }
    }
}
