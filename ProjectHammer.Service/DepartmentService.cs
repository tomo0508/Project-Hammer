using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProjectHammer.DAL;
using ProjectHammer.DAL.Entities;
using ProjectHammer.Service.Interfaces;
using ProjectHammer.Service.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectHammer.Service
{
    /// <summary>
    /// Department service class
    /// </summary>
    public class DepartmentService : IDepartmentService, IService<IDepartment>
    {
        #region Fields

        /// <summary>
        /// Department context field
        /// </summary>
        private readonly CompanyContext context;

        /// <summary>
        /// Mapper
        /// </summary>
        private readonly IMapper mapper;

        #endregion

        #region Constructor

        /// <summary>
        /// Department service constructor
        /// </summary>
        /// <param name="context"></param>
        /// <param name="mapper"></param>
        public DepartmentService(CompanyContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        #endregion

        #region Methods


        /// <summary>
        /// Add new department
        /// </summary>
        /// <param name="department">department</param>
        public async Task Add(IDepartment department)
        {
            var departmentToAdd = mapper.Map<Department>(department);
            context.Add(departmentToAdd);
            await context.SaveChangesAsync();
        }


        /// <summary>
        /// Update department
        /// </summary>
        /// <param name="department">department</param>
        public async Task Update(IDepartment department)
        {
            var departmentToEdit = mapper.Map<Department>(department);

            context.Update(departmentToEdit);
            await context.SaveChangesAsync();
        }

        /// <summary>
        /// Delete department
        /// </summary>
        /// <param name="department">department</param>
        public async Task Delete(IDepartment department)
        {
            var departmentToRemove = mapper.Map<Department>(department);

            departmentToRemove = context.Departments
           .Where(x => x.DepartmentNo == department.DepartmentNo)
           .FirstOrDefault();

            context.Departments.Remove(departmentToRemove);
            await context.SaveChangesAsync();
        }

        /// <summary>
        /// Get department
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>department</returns>
        public async Task<IDepartment> GetDepartment(int id)
        {
            var department = await context.Departments
                .Include(e => e.Employees)
                .FirstOrDefaultAsync(d => d.DepartmentNo == id);

            return mapper.Map<IDepartment>(department);
        }

        /// <summary>
        /// Gets departments
        /// </summary>
        /// <returns>departments</returns>
        public async Task<IEnumerable<IDepartment>> GetDepartments()
        {
            var departments = await context.Departments.ToListAsync();
            var departmentsToMap = mapper.Map<IEnumerable<IDepartment>>(departments);

            return mapper.Map<IEnumerable<DepartmentPoco>>(departmentsToMap);
        }

        /// <summary>
        /// Gets number of employees in "Development" department
        /// </summary>
        /// <returns>departments</returns>
        public async Task<IList<IDepartment>> GetDevelopmentEmployees()
        {
            var result = await context
                .Departments
                .Select(d => new DepartmentPoco()
                {
                    DepartmentName = d.DepartmentName,
                    DepartmentLocation = d.DepartmentLocation,
                    NumberOfEmployees = d.Employees.Count
                }).Where(e => e.DepartmentName.Equals("Development")).ToListAsync();

            return mapper.Map<IList<IDepartment>>(result);

        }

        /// <summary>
        /// Gets departments that has more than one employee
        /// </summary>
        /// <returns>departments</returns>
        public async Task<IList<IDepartment>> GetDepartmentEmployees()
        {

            var result = await context
                .Departments
                .Where(d => d.Employees.Count > 1)
                .Select(d => new DepartmentPoco()
                {
                    DepartmentLocation = d.DepartmentLocation,
                    NumberOfEmployees = d.Employees.Count
                }).ToListAsync();

            return mapper.Map<IList<IDepartment>>(result); ;
        }


        #endregion
    }
}
