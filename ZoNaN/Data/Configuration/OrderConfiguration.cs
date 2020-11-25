using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZoNaN.Data.Models;

namespace ZoNaN.Data.Configuration
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder
                .HasKey(m => m.Id);
            builder
                .Property(m => m.Id)
                .ValueGeneratedOnAdd();
            builder
                .Property(m => m.Name)
                .HasMaxLength(50);
            builder
                .Property(m => m.ProductId)
                .HasMaxLength(50);
            builder
                .Property(m => m.Quantity)
                .HasMaxLength(50);
            builder
                .Property(m => m.OrderNumber)
                .HasMaxLength(50);
            builder
                .Property(m => m.Price)
                .HasColumnType("money");
            builder
                .Property(m => m.Total)
                .HasColumnType("money");
            builder
                .Property(m => m.Photo)
                .HasMaxLength(50);
            builder
                .ToTable("Orders");
        }
    }
}
