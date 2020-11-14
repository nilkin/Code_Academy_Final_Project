using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZoNaN.Models;

namespace ZoNaN.Data.Configuration
{
    public class BannerConfiguration : IEntityTypeConfiguration<Banner>
    {
        public void Configure(EntityTypeBuilder<Banner> builder)
        {
            builder
                .HasKey(m => m.Id);
            builder
                .Property(m => m.Id)
                .ValueGeneratedOnAdd();
            builder
                .Property(m => m.Title)
                .HasMaxLength(100);
            builder
                .Property(m => m.SubTitle)
                .HasMaxLength(100);
            builder
                .Property(m => m.Content)
                .HasMaxLength(100);
            builder
                .Property(m => m.Link)
                .HasMaxLength(100);
            builder
                .Property(m => m.Photo)
                .HasMaxLength(100);
            builder
                .Property(m => m.IsDiscount)
                .HasDefaultValue(false);
            builder
                .Property(m => m.IsMain)
                .HasDefaultValue(false);
            builder
                .Property(m => m.IsPromo)
                .HasDefaultValue(false);
            builder.ToTable("Banners");
        }
    }
}
