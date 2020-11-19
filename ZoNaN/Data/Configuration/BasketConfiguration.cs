using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ZoNaN.Models;

namespace ZoNaN.Data.Configuration
{
    public class BasketConfiguration : IEntityTypeConfiguration<Basket>
    {
        public void Configure(EntityTypeBuilder<Basket> builder)
        {
            builder
                .HasKey(m => m.Id);
            builder
                .Property(m => m.Id)
                .ValueGeneratedOnAdd();
            builder
                .Property(m => m.isCart)
                .HasDefaultValue(false);
            builder
                .Property(m => m.isCompare)
                .HasDefaultValue(false);
            builder
                .Property(m => m.isWish)
                .HasDefaultValue(false);
            builder
                .HasOne(m => m.Product)
                .WithMany(m => m.Baskets)
                .HasForeignKey(m => m.ProductId);
            builder
                .ToTable("Baskets");
        }
    }
}
