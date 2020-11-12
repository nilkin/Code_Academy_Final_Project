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
                .Property(m => m.Quantity)
                .HasMaxLength(100);

            builder.Property(m => m.TotalPrice)
                .HasColumnType("money")
                .IsRequired();
            builder
                .Property(m => m.isCart)
                .HasMaxLength(700);
            builder
                .Property(m => m.isCompare)
                .IsRequired();
            builder
                .Property(m => m.isWish)
                .IsRequired();
            builder
                .HasOne(m => m.Chekout)
                .WithMany(m => m.Bascets)
                .HasForeignKey(m => m.CheckoutId);
            builder
                .ToTable("Baskets");
        }
    }
}
