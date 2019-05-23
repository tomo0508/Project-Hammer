using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ProjectHammer.Service.Interfaces
{
    /// <summary>
    /// Employee  interface
    /// </summary>
    public interface IEmployee
    {
        /// <summary>
        /// Gets or sets EmployeeNo
        /// </summary>
        int EmployeeNo { get; set; }

        /// <summary>
        /// Gets or sets EmployeeName
        /// </summary>
        string EmployeeName { get; set; }

        /// <summary>
        /// Gets or sets Salary
        /// </summary>
        float Salary { get; set; }

        /// <summary>
        /// Gets or sets DepartmentNo
        /// </summary>
        int DepartmentNo { get; set; }

        IDepartment Department { get; set; }

        DateTime LastModifyDate { get; set; }
    }
}
