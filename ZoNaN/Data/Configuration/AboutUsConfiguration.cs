using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZoNaN.Models;

namespace ZoNaN.Data.Configuration
{
    public class AboutUsConfiguration : IEntityTypeConfiguration<AboutUs>
    {
        public void Configure(EntityTypeBuilder<AboutUs> builder)
        {
            builder
     .HasKey(m => m.Id);

            builder
                .Property(m => m.Id)
                .ValueGeneratedOnAdd();
            builder
                .Property(m => m.Title)
                .HasMaxLength(50)
                .IsRequired();
            builder
                .Property(m => m.Text)
                .HasMaxLength(700)
                .HasColumnType("ntext");
            builder
                .Property(m => m.Photo)
                .HasMaxLength(100);
            builder
                .ToTable("AboutUs");
        }
    }
}
