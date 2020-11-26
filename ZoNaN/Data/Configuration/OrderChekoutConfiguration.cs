using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ZoNaN.Models;

namespace ZoNaN.Data.Configuration
{
    public class OrderChekoutConfiguration : IEntityTypeConfiguration<OrderChekout>
    {
        public void Configure(EntityTypeBuilder<OrderChekout> builder)
        {

            builder
                .HasKey(m => m.Id);
            builder
                .Property(m => m.Id)
                .ValueGeneratedOnAdd();
            builder
                .HasKey(m => new { m.ChekoutId, m.OrderId });
            builder
                .HasOne(m => m.Chekout)
                .WithMany(b => b.OrderChekouts)
                .HasForeignKey(m => m.ChekoutId);
            builder
                .HasOne(m => m.Order)
                .WithMany(c => c.OrderChekouts)
                .HasForeignKey(m => m.OrderId);
            builder
                .ToTable("OderChekouts");
        }
    }
}
