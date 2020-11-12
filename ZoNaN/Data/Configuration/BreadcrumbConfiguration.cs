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
                .Property(m => m.IsAboutUs);
            builder
                .Property(m => m.IsBlog);
            builder
                .Property(m => m.IsBlogSingle);
            builder
                .Property(m => m.IsCart);
            builder
                .Property(m => m.IsChekout);
            builder
                .Property(m => m.IsCompare);
            builder
                .Property(m => m.IsContact);
            builder
                .Property(m => m.IsLogin);
            builder
                .Property(m => m.IsProduct);
            builder
                .Property(m => m.IsProductSingle);
            builder
                .Property(m => m.IsProfile);
            builder
                .Property(m => m.IsRegister);
            builder
                .Property(m => m.IsWish);

            builder.ToTable("Breadcrumbs");
        }
    }
}
