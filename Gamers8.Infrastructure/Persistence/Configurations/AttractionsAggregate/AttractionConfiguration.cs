using Gamers8.Core.Entities.AttractionsAggregate;
using Gamers8.Infrastructure.Persistence.Configurations.Base;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
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

            //TODO: Add index and unique constrain.
            //builder.HasIndex(a => a.Title.DescriptionAr).IsUnique();
            //builder.HasIndex(a => a.Title.DescriptionEn).IsUnique();


            builder.OwnsOne(a => a.Title, t =>
            {
                t.Property(n => n.DescriptionAr).HasColumnName("TitleAr").IsRequired().HasMaxLength(50);
                t.Property(n => n.DescriptionEn).HasColumnName("TitleEn").IsRequired().HasMaxLength(50);
            });


            builder.Property(a => a.AttractionCategory)
                 .IsRequired();

            builder.Property(a => a.DefaultImagePath)
                 .IsRequired();

            builder.OwnsOne(a => a.Description, t =>
            {
                t.Property(n => n.DescriptionAr).HasColumnName("DescriptionAr").IsRequired().HasMaxLength(50);
                t.Property(n => n.DescriptionEn).HasColumnName("DescriptionEn").IsRequired().HasMaxLength(50);
            });

            builder.OwnsOne(a => a.OpeningTimes, t =>
            {
                t.Property(n => n.DescriptionAr).HasColumnName("OpeningTimesAr").HasMaxLength(200);
                t.Property(n => n.DescriptionEn).HasColumnName("OpeningTimesEn").HasMaxLength(200);
            });



            builder.Property(a => a.SeasonZone)
                .IsRequired();

            builder.OwnsOne(a => a.DateTime, t =>
            {
                t.Property(n => n.Start).IsRequired();
            });

            builder.Property(a => a.IncludedInEntranceTicket)
                .IsRequired();

            builder.Property(a => a.RequiresSignup)
                .IsRequired();

            builder.Property(a => a.IsFeaturedEvent)
                .IsRequired();

            //builder.Property(a => a.Tags)
            //    .IsRequired();

            builder.HasMany(a => a.Tags)
                .WithMany(a => a.Attractions);

            builder.HasMany(a => a.GalleryItems)
              .WithOne(a => a.Attraction);
        }
    }
}
