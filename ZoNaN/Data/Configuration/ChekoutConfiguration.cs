using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
                .Property(m => m.Payment)
                .HasDefaultValue(false)
                .IsRequired();
            builder
                .Property(m => m.Shipping)
                .HasDefaultValue(false);
            builder
                .Property(m => m.IsGuest)
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
                .HasOne(m => m.Bascet)
                .WithOne(m => m.Chekout)
                .HasForeignKey<Chekout>(m => m.BasketId);
            builder
                .ToTable("Chekouts");
        }
    }
}
