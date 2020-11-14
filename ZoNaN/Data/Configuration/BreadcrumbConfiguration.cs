using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZoNaN.Data.Models;

namespace ZoNaN.Data.Configuration
{
    public class BreadcrumbConfiguration : IEntityTypeConfiguration<Breadcrumb>
    {
        public void Configure(EntityTypeBuilder<Breadcrumb> builder)
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
                .Property(m => m.Photo)
                .HasMaxLength(100)
                .IsRequired();
            builder
                .Property(m => m.Path)
                .HasMaxLength(50);
            builder
                .Property(m => m.Link)
                .HasMaxLength(50);
            builder
                .Property(m => m.IsAboutUs)
                .HasDefaultValue(false);
            builder
                .Property(m => m.IsBlog)
                .HasDefaultValue(false);
            builder
                .Property(m => m.IsBlogSingle)
                .HasDefaultValue(false);
            builder
                .Property(m => m.IsCart)
                .HasDefaultValue(false);
            builder
                .Property(m => m.IsChekout)
               .HasDefaultValue(false);
            builder
                .Property(m => m.IsCompare)
                .HasDefaultValue(false);
            builder
                .Property(m => m.IsContact)
                .HasDefaultValue(false);
            builder
                .Property(m => m.IsLogin)
                .HasDefaultValue(false);
            builder
                .Property(m => m.IsProduct)
                .HasDefaultValue(false);
            builder
                .Property(m => m.IsProductSingle)
                .HasDefaultValue(false);
            builder
                .Property(m => m.IsProfile)
                .HasDefaultValue(false);
            builder
                .Property(m => m.IsRegister)
                .HasDefaultValue(false);
            builder
                .Property(m => m.IsWish)
                .HasDefaultValue(false);

            builder.ToTable("Breadcrumbs");
        }
    }
}
