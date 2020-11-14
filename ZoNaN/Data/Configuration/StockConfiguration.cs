using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZoNaN.Models;

namespace ZoNaN.Data.Configuration
{
    public class StockConfiguration : IEntityTypeConfiguration<Stock>
    {
        public void Configure(EntityTypeBuilder<Stock> builder)
        {
            builder
                .HasKey(m => m.Id);

            builder
                .Property(m => m.Id)
                .ValueGeneratedOnAdd();
            builder
                .Property(m => m.Status)
                .HasDefaultValue(false);
            builder
                .Property(m => m.Quantity)
                .HasDefaultValue(0);
            builder
                .Property(m => m.Price)
                .HasColumnType("money")
                .IsRequired();
            builder.ToTable("Stock");
        }
    }
}
