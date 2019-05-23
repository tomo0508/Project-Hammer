using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjectHammer.Service.Interfaces
{
    /// <summary>
    /// Employee service interface
    /// </summary>
    public  interface IEmployeeService
    {

        /// <summary>
        /// Gets employees
        /// </summary>
        /// <returns>Employees</returns>
       Task< IEnumerable<IEmployee>> GetEmployees();

        /// <summary>
        /// Gets employee
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Employee</returns>
       Task<IEmployee> GetEmployee(int id);

        /// <summary>
        /// Exports employees as tex tfile
        /// </summary>
        /// <returns>Employees</returns>
       string  ExportEmployees();

        /// <summary>
        /// Gets average salary
        /// </summary>
        /// <returns>salary</returns>
        string AverageSalary();

        /// <summary>
        /// Gets second highest salary
        /// </summary>
        /// <returns>salary</returns>
        string SecondHighestSalary();

        /// <summary>
        /// Updates salary
        /// </summary>
        /// <param name="employeeNo"> employeeNo</param>
        /// <param name="salaryPercent">salaryPercent</param>
        void ChangeSalary(int employeeNo, int salaryPercent);
       
    }
}
