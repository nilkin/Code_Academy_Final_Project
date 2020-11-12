using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZoNaN.Models;

namespace ZoNaN.Data.Configuration
{
    public class SettingConfiguration : IEntityTypeConfiguration<Setting>
    {
        public void Configure(EntityTypeBuilder<Setting> builder)
        {
            builder
    .HasKey(m => m.Id);

            builder
                .Property(m => m.Id)
                .ValueGeneratedOnAdd();

            builder
                .Property(m => m.Address)
                .HasMaxLength(100)
                .IsRequired();
            builder
                .Property(m => m.Info)
                .HasMaxLength(700)
                .HasColumnType("ntext");
            builder
                .Property(m => m.Email)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .Property(m => m.Phone)
                .IsRequired()
                .HasMaxLength(15);
            builder
                .Property(m => m.Logo)
                .HasMaxLength(100);


            builder.ToTable("Settings");
        }
    }
}
