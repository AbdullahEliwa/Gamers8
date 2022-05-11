using Gamers8.Core.Entities.SharedAggregate;
using Gamers8.Infrastructure.Persistence.Configurations.Base;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamers8.Infrastructure.Persistence.Configurations.SharedAggregate
{
    public class CountryConfiguration : AuditableEntityTypeConfiguration<Country, int>
    {
        public override void Configure(EntityTypeBuilder<Country> builder)
        {
            base.Configure(builder);

            builder.OwnsOne(s => s.Name, t =>
            {
                t.Property(n => n.DescriptionAr).HasColumnName("TitleAr").IsRequired().HasMaxLength(50);
                t.Property(n => n.DescriptionEn).HasColumnName("TitleEn").IsRequired().HasMaxLength(50);
            });
        }
    }
}
