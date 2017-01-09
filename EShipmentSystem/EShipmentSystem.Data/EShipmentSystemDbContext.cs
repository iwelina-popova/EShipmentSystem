namespace EShipmentSystem.Data
{
    using System;
    using System.Linq;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    using Models;
    using Models.BaseEntities;

    public class EShipmentSystemDbContext : IdentityDbContext<ApplicationUser>
    {
        public EShipmentSystemDbContext(DbContextOptions<EShipmentSystemDbContext> options)
            : base(options)
        {
        }

        public DbSet<ShipmentData> ShipmentDatas { get; set; }

        public DbSet<AdditionalOptions> AdditionalOptions { get; set; }

        public DbSet<Receiver> Receivers { get; set; }

        public override int SaveChanges()
        {
            this.ApplyAuditInfoRules();
            return base.SaveChanges();
        }

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    base.OnModelCreating(builder);

        //    builder.Entity<ShipmentData>()
        //        .HasOne(sd => sd.User)
        //        .WithMany(u => u.ShipmentDatas);

        //}

        private void ApplyAuditInfoRules()
        {
            // Approach via @julielerman: http://bit.ly/123661P
            foreach (var entry in
                this.ChangeTracker.Entries()
                    .Where(
                        e =>
                        e.Entity is IAuditInfo && ((e.State == EntityState.Added) || (e.State == EntityState.Modified))))
            {
                var entity = (IAuditInfo)entry.Entity;

                if (entry.State == EntityState.Added && entity.CreatedOn == default(DateTime))
                {
                    entity.CreatedOn = DateTime.UtcNow;
                }
                else
                {
                    entity.ModifiedOn = DateTime.UtcNow;
                }
            }
        }
    }
}
