using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZoNaN.Models;

namespace ZoNaN.Data.Configuration
{
    public class ProductBasketConfiguration : IEntityTypeConfiguration<ProductBascet>
    {
public void Configure(EntityTypeBuilder<ProductBascet> builder)
        {
            builder
                .HasKey(m => new { m.BascetId, m.ProductId });
            builder
                .HasOne(m => m.Bascet)
                .WithMany(b => b.ProductBascets)
                .HasForeignKey(m => m.BascetId);
            builder
                .HasOne(m => m.Product)
                .WithMany(c => c.ProductBascets)
                .HasForeignKey(m => m.ProductId);
        }
    }
}
