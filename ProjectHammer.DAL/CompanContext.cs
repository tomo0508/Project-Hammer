using Microsoft.EntityFrameworkCore;
using ProjectHammer.DAL.Entities;
using ProjectHammer.DAL.Helpers;
using System;

namespace ProjectHammer.DAL
{
    public class CompanyContext : DbContext
    {
        public CompanyContext(DbContextOptions<CompanyContext> options) : base(options)
        {

        }

        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.RemovePluralizingTableNameConvention();

            
            modelBuilder.ApplyConfiguration(new LoginConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
          

            modelBuilder.Entity<Login>().HasData(new Login { LoginNo = 1, LoginUserName = "Bill", LoginPassword = "ItsNotSoft" });
            modelBuilder.Entity<Login>().HasData(new Login { LoginNo = 2, LoginUserName = "Jean", LoginPassword = "trollsRule" });


            modelBuilder.Entity<Department>().HasData(new Department { DepartmentNo = 1, DepartmentName = "Development", DepartmentLocation = "London" });
            modelBuilder.Entity<Department>().HasData(new Department { DepartmentNo = 2, DepartmentName = "Development", DepartmentLocation = "Zurich" });
            modelBuilder.Entity<Department>().HasData(new Department { DepartmentNo = 3, DepartmentName = "Development", DepartmentLocation = "Osijek" });
            modelBuilder.Entity<Department>().HasData(new Department { DepartmentNo = 4, DepartmentName = "Sales", DepartmentLocation = "London" });
            modelBuilder.Entity<Department>().HasData(new Department { DepartmentNo = 5, DepartmentName = "Sales", DepartmentLocation = "Zurich" });
            modelBuilder.Entity<Department>().HasData(new Department { DepartmentNo = 6, DepartmentName = "Sales", DepartmentLocation = "Osijek" });
            modelBuilder.Entity<Department>().HasData(new Department { DepartmentNo = 7, DepartmentName = "Sales", DepartmentLocation = "Basel" });
            modelBuilder.Entity<Department>().HasData(new Department { DepartmentNo = 8, DepartmentName = "Sales", DepartmentLocation = "Lugano" });

            modelBuilder.Entity<Employee>().HasData(new Employee() { EmployeeNo = 1, EmployeeName = "Fred Davies", Salary = 50000, DepartmentNo = 4 });
            modelBuilder.Entity<Employee>().HasData(new Employee() { EmployeeNo = 2, EmployeeName = "Bernard Katic", Salary = 50000, DepartmentNo = 3 });
            modelBuilder.Entity<Employee>().HasData(new Employee() { EmployeeNo = 3, EmployeeName = "Rich Davies", Salary = 30000, DepartmentNo = 5 });
            modelBuilder.Entity<Employee>().HasData(new Employee() { EmployeeNo = 4, EmployeeName = "Eva Dobos", Salary = 30000, DepartmentNo = 6 });
            modelBuilder.Entity<Employee>().HasData(new Employee() { EmployeeNo = 5, EmployeeName = "Mario Hunjadi", Salary = 25000, DepartmentNo = 8 });
            modelBuilder.Entity<Employee>().HasData(new Employee() { EmployeeNo = 6, EmployeeName = "Jean Michele", Salary = 25000, DepartmentNo = 7 });
            modelBuilder.Entity<Employee>().HasData(new Employee() { EmployeeNo = 7, EmployeeName = "Bill Gates", Salary = 25000, DepartmentNo = 1 });
            modelBuilder.Entity<Employee>().HasData(new Employee() { EmployeeNo = 8, EmployeeName = "Maja Janic", Salary = 30000, DepartmentNo = 3 });
            modelBuilder.Entity<Employee>().HasData(new Employee() { EmployeeNo = 9, EmployeeName = "Igor Horvat", Salary = 35000, DepartmentNo = 3 });


        }

    }
}