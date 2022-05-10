﻿using Gamers8.Core.Entities.EventAggregate;
using Gamers8.Infrastructure.Persistence.Configurations.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamers8.Infrastructure.Persistence.Configurations.EventAggregate
{
    public class SummitConfiguration : AuditableEntityTypeConfiguration<Summit, Guid>
    {
        public override void Configure(EntityTypeBuilder<Summit> builder)
        {
            base.Configure(builder);

            builder.Property(s => s.Title)
                .IsRequired();
            builder.OwnsOne(s => s.Title, t =>
            {
                t.Property(n => n.DescriptionAr).HasColumnName("TitleAr").IsRequired().HasMaxLength(50);
                t.Property(n => n.DescriptionEn).HasColumnName("TitleEn").IsRequired().HasMaxLength(50);
            });

            builder.Property(s => s.DefaultImagePath)
                .IsRequired();
            builder.OwnsOne(s => s.DefaultImagePath, t =>
            {
                t.Property(n => n.DescriptionAr).HasColumnName("DefaultImagePathAr").IsRequired().HasMaxLength(150);
                t.Property(n => n.DescriptionEn).HasColumnName("DefaultImagePathEn").IsRequired().HasMaxLength(150);
            });

            builder.Property(s => s.SeasonZone)
               .IsRequired();

            builder.Property(s => s.DateTime)
                .IsRequired();
            builder.OwnsOne(s => s.DateTime, t =>
            {
                t.Property(n => n.Start).HasColumnType("Date").HasColumnName("StartingDate").IsRequired();
                t.Property(n => n.End).HasColumnType("Date").HasColumnName("EndingDate").IsRequired();
            });

            builder.OwnsOne(s => s.FactsSheet, t =>
            {
                t.Property(n => n.DescriptionAr).HasColumnName("NameAr").IsRequired();
                t.Property(n => n.DescriptionEn).HasColumnName("NameEn").IsRequired();
            });

            builder.Property(s => s.ProgramFilePath)
                .IsRequired(false);
            builder.OwnsOne(s => s.ProgramFilePath, t =>
            {
                t.Property(n => n.DescriptionAr).HasColumnName("ProgramFilePathAr").IsRequired().HasMaxLength(150);
                t.Property(n => n.DescriptionEn).HasColumnName("ProgramFilePathEn").IsRequired().HasMaxLength(150);
            });


            builder.Property(s => s.AgeGroupFrom)
               .IsRequired(false);

            builder.Property(s => s.RequireSignup)
               .IsRequired()
               .HasDefaultValue(true);

            builder.Property(s => s.IsIncludedInEntranceTicket)
              .IsRequired()
              .HasDefaultValue(true);

            builder.Property(s => s.IsFeaturedEvent)
              .IsRequired();

            builder.HasMany(s => s.Tags)
                .WithMany(t => t.Summits);

            builder.HasMany(s => s.Speakers)
                .WithMany(t => t.Summits);
        }
    }
}
