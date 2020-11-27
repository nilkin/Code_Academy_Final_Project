using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ZoNaN.Models;

namespace ZoNaN.Data.Configuration
{
    public class ChekoutConfiguration : IEntityTypeConfiguration<Chekout>

    {
        public void Configure(EntityTypeBuilder<Chekout> builder)
        {

            builder
                .HasKey(m => m.Id);
            builder
                .Property(m => m.Id)
                .ValueGeneratedOnAdd();
            builder
                .Property(m => m.Gender)
                .HasMaxLength(50);
            builder
                .Property(m => m.Name)
                .HasMaxLength(50)
                .IsRequired();
            builder
                .Property(m => m.Surname)
                .HasMaxLength(50)
                .IsRequired();
            builder
                .Property(m => m.Email)
                .HasMaxLength(50)
                .IsRequired();
            builder
                .Property(m => m.Agreement)
                .HasDefaultValue(false)
                .IsRequired();
            builder
                .Property(m => m.PaymentMethod)
                .HasMaxLength(60);
            builder
                .Property(m => m.City)
                .HasMaxLength(50);
            builder
                .Property(m => m.Address)
                .HasMaxLength(50);
            builder
                .Property(m => m.Shipping)
                .HasDefaultValue(false);
            builder
                .Property(m => m.Message)
                .HasColumnType("ntext")
                .HasMaxLength(500);
            builder
                .HasOne(m => m.Customer)
                .WithOne(m => m.Chekout)
                .HasForeignKey<Chekout>(m => m.CustomerId);
            builder
                .ToTable("Chekouts");
        }
    }
}
