using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ZoNaN.Models;

namespace ZoNaN.Data.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>

    {
        public void Configure(EntityTypeBuilder<Product> builder)
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
                .Property(m => m.Discount)
                .HasMaxLength(50);
            builder
                .Property(m => m.IsBestSel)
                .HasDefaultValue(false);
            builder
                .Property(m => m.IsFeatured)
                .HasDefaultValue(false);
            builder
                .Property(m => m.IsNew)
                .HasDefaultValue(false);
            builder
                .Property(m => m.Star)
                .HasDefaultValue(1)
                .HasMaxLength(10);
            builder
                .Property(m => m.Description)
                .HasColumnType("ntext");
            builder
                .Property(m => m.Color)
                .HasMaxLength(50);
            builder
                .Property(m => m.Dimension)
                .HasMaxLength(50);
            builder
                .Property(m => m.Size)
                .HasMaxLength(50);            
            builder
               .HasOne(m => m.Stock)
               .WithMany(m => m.Products)
               .HasForeignKey(m => m.StockId);
            builder
                .HasOne(m => m.SubCategory)
                .WithMany(m => m.Products)
                .HasForeignKey(m => m.SubCategoryId);

            builder.ToTable("Products");

        }
    }
}
