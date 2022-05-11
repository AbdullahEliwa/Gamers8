using Gamers8.Core.Entities.SharedAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamers8.Infrastructure.Persistence.Configurations.SharedAggregate
{
    public class TagConfiguration : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.HasKey(c => c.Name);

            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(50);




        }
    }
}
