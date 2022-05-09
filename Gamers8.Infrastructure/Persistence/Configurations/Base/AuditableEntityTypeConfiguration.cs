using Gamers8.Core.Entities.Base;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamers8.Infrastructure.Persistence.Configurations.Base
{
    public class AuditableEntityTypeConfiguration<T, TKey> : BaseEntityTypeConfiguration<T, TKey>
       where T : AuditableEntity<TKey>
    {
        public override void Configure(EntityTypeBuilder<T> builder)
        {
            base.Configure(builder);


            builder.Property(c => c.Created)
                .IsRequired();

            builder.Property(c => c.CreatedBy)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(c => c.LastModified)
                .IsRequired(false);

            builder.Property(c => c.LastModifiedBy)
                .HasMaxLength(50)
                .IsRequired(false);
        }
    }
}
