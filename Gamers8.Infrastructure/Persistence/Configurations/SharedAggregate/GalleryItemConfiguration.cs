using Gamers8.Core.Entities.AttractionsAggregate;
using Gamers8.Infrastructure.Persistence.Configurations.Base;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamers8.Infrastructure.Persistence.Configurations.SharedAggregate
{
    public class GalleryItemConfiguration : AuditableEntityTypeConfiguration<GalleryItem, Guid>
    {
        public override void Configure(EntityTypeBuilder<GalleryItem> builder)
        {
            builder.HasIndex(g => g.ItemName).IsUnique();

            builder.Property(g => g.ItemName)
              .IsRequired();

            builder.Property(g => g.FilePath)
              .IsRequired();
        }
    }
}
