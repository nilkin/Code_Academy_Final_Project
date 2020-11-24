using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZoNaN.Models;

namespace ZoNaN.Data.Configuration
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder
                .HasKey(m => m.Id);

            builder
                .Property(m => m.Id)
                .ValueGeneratedOnAdd();
            builder
                .Property(m => m.Gender)
                .HasMaxLength(50)
                .IsRequired();
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
                .Property(m => m.Password)
                .HasMaxLength(100)
                .IsRequired();
            builder
                .Property(m => m.Token)
                .HasMaxLength(100);
            builder
                .Property(m => m.InfoText)
                .HasMaxLength(50);
            builder
                .Property(m => m.City)
                .HasMaxLength(50);
            builder
                .Property(m => m.Address)
                .HasMaxLength(50);
            builder
                .Property(m => m.Mobile)
                .HasMaxLength(50);
            builder
                .Property(m => m.Birth)
                .HasColumnType("Date")
                .IsRequired();
            builder
                .Property(m => m.IsSubscribe)
                .HasDefaultValue(false)
                .IsRequired();
            builder
                .Property(m => m.Photo)
                .HasDefaultValue("avatar.jpg")
                .HasMaxLength(100);
            builder
                .ToTable("Customers");
        }
    }
}
