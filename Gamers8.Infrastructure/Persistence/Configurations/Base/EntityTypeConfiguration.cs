using Gamers8.Core.Entities.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamers8.Infrastructure.Persistence.Configurations.Base
{
    public class BaseEntityTypeConfiguration<T, TKey> : IEntityTypeConfiguration<T>
         where T : BaseEntity<TKey>
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.RowVersion).IsRowVersion();
        }
    }
}
