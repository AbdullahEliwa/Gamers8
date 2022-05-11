using Gamers8.Core.Entities.SummitAggregate;
using Gamers8.Infrastructure.Persistence.Configurations.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamers8.Infrastructure.Persistence.Configurations.SummitAggregate
{
    public class SummitDayConfiguration : AuditableEntityTypeConfiguration<SummitDay, int>
    {
        public override void Configure(EntityTypeBuilder<SummitDay> builder)
        {
            base.Configure(builder);

            builder.Property(s => s.Date).HasColumnType("Date").IsRequired();
        }
    }
}
