using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProjectHammer.DAL;
using ProjectHammer.DAL.Entities;
using ProjectHammer.Service.Interfaces;
using ProjectHammer.Service.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHammer.Service
{
    public class EmployeeService : IEmployeeService, IService<IEmployee>
    {
        #region Fields

        /// <summary>
        /// Employe context field
        /// </summary>
        private readonly CompanyContext context;

        /// <summary>
        /// Mapper
        /// </summary>
        private readonly IMapper mapper;

        #endregion

        #region Constructor

        /// <summary>
        /// Employee service constructor
        /// </summary>
        /// <param name="context"></param>
        /// <param name="mapper"></param>
        public EmployeeService(CompanyContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Adds employee
        /// </summary>
        /// <param name="employee">employee</param>
        public async Task Add(IEmployee employee)
        {
            var employeeToAdd = mapper.Map<Employee>(employee);

            context.Add(employeeToAdd);
            await context.SaveChangesAsync();
        }

        /// <summary>
        /// Updates employee
        /// </summary>
        /// <param name="employee">employee</param>
        public async Task Update(IEmployee employee)
        {
            var employeeToEdit = mapper.Map<Employee>(employee);

            context.Update(employeeToEdit);
            await context.SaveChangesAsync();
        }

        /// <summary>
        /// Deletes employee
        /// </summary>
        /// <param name="employee">employee</param>
        public async Task Delete(IEmployee employee)
        {
            var employeeToRemove = mapper.Map<Employee>(employee);

            employeeToRemove = context.Employees
           .Where(x => x.EmployeeNo == employee.EmployeeNo)
           .FirstOrDefault();

            context.Employees.Remove(employeeToRemove);
            await context.SaveChangesAsync();
        }


        /// <summary>
        /// Gets employee
        /// </summary>
        /// <param name="id">employee</param>
        /// <returns>employee</returns>
        public async Task<IEmployee> GetEmployee(int id)
        {
            var employee = await context.Employees
                .Include(e => e.Department)
                .Where(e => e.EmployeeNo == id)
                .FirstOrDefaultAsync();

            return mapper.Map<IEmployee>(employee);


        }

        /// <summary>
        /// Gets employees
        /// </summary>
        /// <returns>employees</returns>
        public async Task<IEnumerable<IEmployee>> GetEmployees()
        {
            var employees = await context.Employees.ToListAsync();
            var employeessToMap = mapper.Map<IEnumerable<IEmployee>>(employees);

            return mapper.Map<IEnumerable<EmployeePoco>>(employeessToMap);
        }

        /// <summary>
        /// Exports employees as text file
        /// </summary>
        /// <returns>employees</returns>
        public string ExportEmployees()
        {

            var employees = context.Employees.Include(e => e.Department);

            var names = typeof(IEmployee).GetProperties()
                        .Select(property => property.Name)
                        .ToArray();
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("+---------------+---------------+---------------+---------------+\n");
            foreach (var item in names.Where((item, index) => index < 4))
            {
                stringBuilder.Append("|" + item.ToString() + "\t");
            }

            stringBuilder.Append("|\n");

            foreach (var item in employees)
            {
                stringBuilder.Append("+---------------+---------------+---------------+---------------+\n");
                stringBuilder.Append("|" + item.EmployeeNo.ToString() + "\t\t|" + item.EmployeeName.ToString() + "\t|" + item.Salary.ToString() + "\t|\t" + item.DepartmentNo + "\t\t|");
                stringBuilder.AppendLine();

            }

            return stringBuilder.ToString();

        }

        /// <summary>
        /// Gets average salary in "Development" departments
        /// except "Developmet" department in London.
        /// </summary>
        /// <returns></returns>
        public string AverageSalary()
        {

            float avrgSalary = context.Employees
                .Include(d => d.Department)
                .Where(d => d.Department.DepartmentLocation != "London"
                        && d.Department.DepartmentName == "Development")
                .Average(d => d.Salary);

            return avrgSalary.ToString() + " is average salary for employees in \"Development\" department except London.";
        }


        /// <summary>
        /// Gets second highest salary
        /// </summary>
        /// <returns>salary</returns>
        public string SecondHighestSalary()
        {
            float secondHighestSalary = context.Employees
                .OrderByDescending(x => x.Salary)
                .Select(x => x.Salary)
                .Distinct()
                .Skip(1)
                .First();

            return secondHighestSalary.ToString() + " is the second highest salary in company.";
        }

        /// <summary>
        /// Updates salary
        /// </summary>
        /// <param name="employeeNo">employeNo</param>
        /// <param name="salaryPercent">salaryPercent</param>
        public void ChangeSalary(int employeeNo, int salaryPercent)
        {
            context.Database.ExecuteSqlCommand("spIncreaseSalary @id = {0}, @percent = {1}", employeeNo, salaryPercent);
            //context.SaveChanges();
        }


        public async Task<IEnumerable<IEmployee>> GetApi()
        {
            var employees = await context.Employees.FindAsync();

            return mapper.Map<IEnumerable<IEmployee>>(employees);
        }

        #endregion
    }
}
