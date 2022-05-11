using Microsoft.EntityFrameworkCore;
using System.Reflection;

using Gamers8.Core.Entities.Base;
using Gamers8.Core.Entities.SummitAggregate;
using Gamers8.Core.Abstractions;
using Gamers8.Infrastructure.Persistence.Extensions;
using Gamers8.Core.Entities.SharedAggregate;
using Gamers8.Core.Entities.AttractionsAggregate;

namespace Booking.Infrastructure.Persistence
{
    public class Gamers8Context : DbContext
    {
        public Gamers8Context(DbContextOptions options) : base(options)
        {

        }

        #region DbSets
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Speaker> Speakers { get; set; }
        public DbSet<Summit> Summits { get; set; }
        public DbSet<SummitDay> SummitDays { get; set; }
        public DbSet<SummitSession> SummitSessions { get; set; }
        public DbSet<Attraction> Attractions { get; set; }
        public DbSet<GalleryItem> GalleryItems { get; set; }


        #endregion

        public async Task<bool> SaveEntitiesAsync<T>(CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity<T>>())
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedBy = "Na";
                        entry.Entity.Created = DateTimeOffset.UtcNow;
                        break;

                    case EntityState.Modified:
                        entry.Entity.LastModifiedBy = "Na";
                        entry.Entity.LastModified = DateTimeOffset.UtcNow;
                        break;
                }

            var result = await base.SaveChangesAsync(cancellationToken);
            return result > 0;
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            foreach (var entityType in builder.Model.GetEntityTypes())
                if (typeof(IIsActive).IsAssignableFrom(entityType.ClrType))
                    entityType.AddIsActiveQueryFilter();

            base.OnModelCreating(builder);
        }






    }
}
