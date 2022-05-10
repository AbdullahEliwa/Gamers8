using Gamers8.Infrastructure.Persistence.Configurations.Base;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gamers8.Core.Entities.SharedAggregate;

namespace Gamers8.Infrastructure.Persistence.Configurations.SharedAggregate
{
    public class SpeakerConfiguration : AuditableEntityTypeConfiguration<Speaker, Guid>
    {
        public override void Configure(EntityTypeBuilder<Speaker> builder)
        {
            base.Configure(builder);

            builder.Property(s => s.Name)
            .IsRequired();
            builder.OwnsOne(s => s.Name, t =>
            {
                t.Property(n => n.DescriptionAr).HasColumnName("NameAr").IsRequired().HasMaxLength(50);
                t.Property(n => n.DescriptionEn).HasColumnName("NameEn").IsRequired().HasMaxLength(50);
            });

            builder.Property(s => s.PhotoPath)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(s => s.JobTitle)
            .IsRequired();
            builder.OwnsOne(s => s.JobTitle, t =>
            {
                t.Property(n => n.DescriptionAr).HasColumnName("JobTitleAr").IsRequired().HasMaxLength(50);
                t.Property(n => n.DescriptionEn).HasColumnName("JobTitleEn").IsRequired().HasMaxLength(50);
            });

            builder.Property(s => s.Employer)
            .IsRequired(false);
            builder.OwnsOne(s => s.Employer, t =>
            {
                t.Property(n => n.DescriptionAr).HasColumnName("EmployerAr").IsRequired().HasMaxLength(50);
                t.Property(n => n.DescriptionEn).HasColumnName("EmployerEn").IsRequired().HasMaxLength(50);
            });

            builder.Property(s => s.Brief)
            .IsRequired(false);
            builder.OwnsOne(s => s.Brief, t =>
            {
                t.Property(n => n.DescriptionAr).HasColumnName("BriefAr").IsRequired().HasMaxLength(150);
                t.Property(n => n.DescriptionEn).HasColumnName("BriefEn").IsRequired().HasMaxLength(150);
            });

            builder.Property(s => s.LinkedInProfile)
              .IsRequired(false)
              .HasMaxLength(150);

            builder.Property(s => s.SocialMediaProfile)
              .IsRequired(false)
              .HasMaxLength(150);

            builder.HasOne(s => s.Country)
                .WithMany()
                .HasForeignKey(s => s.CountryId);

        }
    }
}
