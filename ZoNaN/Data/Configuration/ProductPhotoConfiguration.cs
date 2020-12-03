using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZoNaN.Models;

namespace ZoNaN.Data.Configuration
{
    public class ProductPhotoConfiguration : IEntityTypeConfiguration<ProductPhoto>

    {
        public void Configure(EntityTypeBuilder<ProductPhoto> builder)
        {
            builder
                .HasKey(m => m.Id);
            builder
                .Property(m => m.Id)
                .ValueGeneratedOnAdd();
            builder
                .Property(m => m.IsFirstPhoto)
                .HasDefaultValue(false);
            builder
                .Property(m => m.IsSecondPhoto)
                .HasDefaultValue(false);
            builder
                .Property(m => m.Photo)
                .HasMaxLength(50);
            builder
                .HasOne(m => m.Product)
                .WithMany(m => m.ProductPhotos)
                .HasForeignKey(m => m.ProductId);

            builder.ToTable("ProductPhotos");
        }
    }
}
