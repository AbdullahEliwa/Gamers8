using Gamers8.Core.Entities.AttractionsAggregate;
using Gamers8.Infrastructure.Persistence.Configurations.Base;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamers8.Infrastructure.Persistence.Configurations.AttractionsAggregate
{
    public class AttractionConfiguration : AuditableEntityTypeConfiguration<Attraction, Guid>
    {
        public override void Configure(EntityTypeBuilder<Attraction> builder)
        {
            base.Configure(builder);

            builder.HasIndex(a => a.Title).IsUnique();

            builder.Property(a => a.Title)
                 .IsRequired();

            builder.Property(a => a.AttractionCategory)
                 .IsRequired();

            builder.Property(a => a.DefaultImagePath)
                 .IsRequired();

            builder.Property(a => a.SeasonZone)
                .IsRequired();

            builder.Property(a => a.DateTime.Start)
                .IsRequired();

            builder.Property(a => a.IncludedInEntranceTicket)
                .IsRequired();

            builder.Property(a => a.RequiresSignup)
                .IsRequired();

            builder.Property(a => a.IsFeaturedEvent)
                .IsRequired();

            builder.Property(a => a.Tags)
                .IsRequired();

            builder.HasMany(a => a.Tags)
                .WithMany(a => a.Attractions);

            builder.HasMany(a => a.GalleryItems)
              .WithOne(a => a.Attraction);
        }
    }
}
