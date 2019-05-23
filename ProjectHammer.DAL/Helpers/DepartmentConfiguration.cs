using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectHammer.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectHammer.DAL.Helpers
{
   public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(t => t.DepartmentNo);
            builder.Property(t => t.DepartmentName)
                   .HasMaxLength(20);

            builder.Property(t => t.DepartmentLocation)
                   .IsRequired()
                   .HasMaxLength(20);
                   
        }
    }
}