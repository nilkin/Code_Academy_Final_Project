using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZoNaN.Data.Models;

namespace ZoNaN.Data.Configuration
{
    public class ContactUsConfiguration : IEntityTypeConfiguration<ContactUs>

    {
        public void Configure(EntityTypeBuilder<ContactUs> builder)
        {
            builder
                .HasKey(m => m.Id);

            builder
                .Property(m => m.Id)
                .ValueGeneratedOnAdd();

            builder
                .Property(m => m.Fullname)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .Property(m => m.Message)
               .HasMaxLength(1000)
                .HasColumnType("ntext");
            builder
                .Property(m => m.Email)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .Property(m => m.Subject)
                .IsRequired()
                .HasMaxLength(50);
            builder.ToTable("Contacts");
        }
    }
}
