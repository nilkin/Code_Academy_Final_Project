﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZoNaN.Data.Models;

namespace ZoNaN.Data.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
                .HasKey(m => m.Id);

            builder
                .Property(m => m.Id)
                .ValueGeneratedOnAdd();
            builder
                .Property(m => m.Name)
                .HasMaxLength(50)
                .IsRequired();
            builder
                .Property(m => m.Lastname)
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
                .Property(m => m.Photo).HasDefaultValue("avatar.png")
                .HasMaxLength(100);
            builder
                .Property(x => x.Position).HasDefaultValue("user");

            builder.ToTable("Users");
        }
    }
}
