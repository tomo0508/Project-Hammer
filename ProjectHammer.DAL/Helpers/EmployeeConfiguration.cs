using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectHammer.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectHammer.DAL.Helpers
{
 public   class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(l => l.EmployeeNo);
            builder.Property(t => t.EmployeeName)
                   .IsRequired()
                   .HasMaxLength(50);
           
           
        }
    }
}