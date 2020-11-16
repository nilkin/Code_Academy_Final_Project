using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZoNaN.Data.Models;

namespace ZoNaN.Data.Configuration
{
    public class SubscriberConfiguration : IEntityTypeConfiguration<Subscriber>

    {
        public void Configure(EntityTypeBuilder<Subscriber> builder)
        {
            builder
     .HasKey(m => m.Id);

            builder
                .Property(m => m.Id)
                .ValueGeneratedOnAdd();
            builder
                .Property(m => m.Email)
                .HasMaxLength(50);

            builder
                .ToTable("Subscribers");
        }
    }
    
}
