using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjectHammer.Service.Interfaces
{
    /// <summary>
    /// Department service interface
    /// </summary>
    public interface IDepartmentService
    {
        /// <summary>
        /// Gets Departments
        /// </summary>
        /// <returns>Departments</returns>
       Task<IEnumerable<IDepartment>> GetDepartments();

        /// <summary>
        /// Gets department
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>Department</returns>
       Task< IDepartment> GetDepartment(int id);

        /// <summary>
        /// Gets number of emplyees by department
        /// </summary>
        /// <returns>Departments</returns>
        Task<IList<IDepartment>> GetDepartmentEmployees();

       
        /// <summary>
        /// Gets number of employees in "Development department"
        /// </summary>
        /// <returns>Departments</returns>
       Task< IList<IDepartment>> GetDevelopmentEmployees();
    }
}
