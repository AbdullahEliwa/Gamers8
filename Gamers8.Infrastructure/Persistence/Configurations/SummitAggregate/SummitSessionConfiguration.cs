using Gamers8.Core.Entities.SummitAggregate;
using Gamers8.Infrastructure.Persistence.Configurations.Base;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Gamers8.Infrastructure.Persistence.Configurations.SummitAggregate
{
    public class SummitSessionConfiguration : AuditableEntityTypeConfiguration<SummitSession, Guid>
    {
        public override void Configure(EntityTypeBuilder<SummitSession> builder)
        {
            base.Configure(builder);

            builder.OwnsOne(s => s.Title, t =>
            {
                t.Property(n => n.DescriptionAr).HasColumnName("TitleAr").IsRequired().HasMaxLength(50);
                t.Property(n => n.DescriptionEn).HasColumnName("TitleEn").IsRequired().HasMaxLength(50);
            });

            builder.OwnsOne(s => s.DateTime, t =>
            {
                t.Property(n => n.Start).HasColumnName("StartingTime").IsRequired();
                t.Property(n => n.End).HasColumnName("EndingTime").IsRequired();
            });

            builder.OwnsOne(s => s.Desciption, t =>
            {
                t.Property(n => n.DescriptionAr).HasColumnName("NameAr").IsRequired();
                t.Property(n => n.DescriptionEn).HasColumnName("NameEn").IsRequired();
            });

            builder.Property(s => s.SeasonZone)
                .IsRequired();
        }
    }
}
