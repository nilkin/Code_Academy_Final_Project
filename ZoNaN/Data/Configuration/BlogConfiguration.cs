using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZoNaN.Models;

namespace ZoNaN.Data.Configuration
{
    public class BlogConfiguration : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {

            builder
                .HasKey(m => m.Id);

            builder
                .Property(m => m.Id)
                .ValueGeneratedOnAdd();
            builder
                .Property(m => m.Name)
                .HasMaxLength(50)
                .IsRequired();
            builder
                .Property(m => m.Author)
                .HasMaxLength(50)
                .IsRequired();
            builder
                .Property(m => m.Subject)
                .HasMaxLength(50)
                .IsRequired();
            builder
                .Property(m => m.IsNew)
                .HasDefaultValue(false);
            builder
                .Property(m => m.Date)
                .HasColumnType("Date")
                .IsRequired();
            builder
                .Property(m => m.Text)
                .HasColumnType("ntext")
                .IsRequired();
            builder
                .Property(m => m.Photo)
                .HasMaxLength(100);
            builder
                .ToTable("Blogs");
        }
    }
}
