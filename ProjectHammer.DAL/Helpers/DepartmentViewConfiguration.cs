using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectHammer.DAL.Entities;


namespace ProjectHammer.DAL.Helpers
{
   public class DepartmentViewConfiguration : IEntityTypeConfiguration<DepartmentView>
    {
        public void Configure(EntityTypeBuilder<DepartmentView> builder)
        {
            builder.HasKey(t => t.DepartmentNo);
          

        }
    }
}