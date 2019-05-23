using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectHammer.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectHammer.DAL.Helpers
{
    public class LoginConfiguration : IEntityTypeConfiguration<Login>
    {
        public void Configure(EntityTypeBuilder<Login> builder)
        {
            builder.HasKey(l => l.LoginNo);
            builder.Property(t => t.LoginPassword)
                   .IsRequired()
                   .HasMaxLength(20);

            builder.Property(t => t.LoginUserName)
                 .IsRequired()
                 .HasMaxLength(20);
                
        }
    }
}