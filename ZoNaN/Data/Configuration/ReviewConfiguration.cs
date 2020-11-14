using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZoNaN.Models;

namespace ZoNaN.Data.Configuration
{
    public class ReviewConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder
                .HasKey(m => m.Id);

            builder
                .Property(m => m.Id)
                .ValueGeneratedOnAdd();
            builder
                .Property(m => m.Fullname)
                .HasMaxLength(50)
                .IsRequired();
            builder
                .Property(m => m.Email)
                .HasMaxLength(100)
                .IsRequired();
            builder
                .Property(m => m.Message)
                .HasMaxLength(500)
                .IsRequired();
            builder
                .Property(m => m.Rate)
                .IsRequired();
            builder
                .HasOne(m => m.Product)
                .WithMany(m => m.Reviews)
                .HasForeignKey(m => m.ProductId);

            builder.ToTable("Reviews");
        }
    }
}
