using Microsoft.EntityFrameworkCore;
using System.Reflection;

using Gamers8.Core.Entities.Base;
using Gamers8.Core.Services;
using Gamers8.Core.Entities.SummitAggregate;
using Gamers8.Core.Abstractions;
using Gamers8.Infrastructure.Persistence.Extensions;
using Gamers8.Core.Entities.SharedAggregate;

namespace Booking.Infrastructure.Persistence
{
    public class Gamers8Context : DbContext
    {
        private readonly ICurrentUserService _currentUserService;
        public Gamers8Context(DbContextOptions options, ICurrentUserService currentUserService) : base(options)
        {
            _currentUserService = currentUserService;
        }

        #region DbSets
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Speaker> Speakers { get; set; }
        public DbSet<Summit> Summits { get; set; }
        public DbSet<SummitDay> SummitDays { get; set; }
        public DbSet<SummitSession> SummitSessions { get; set; }



        #endregion

        public async Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity<Guid>>())
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedBy = string.IsNullOrEmpty(_currentUserService.UserId) ? "Na" : _currentUserService.UserId;
                        entry.Entity.Created = DateTimeOffset.UtcNow;
                        break;

                    case EntityState.Modified:
                        entry.Entity.LastModifiedBy = string.IsNullOrEmpty(_currentUserService.UserId) ? "Na" : _currentUserService.UserId;
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
