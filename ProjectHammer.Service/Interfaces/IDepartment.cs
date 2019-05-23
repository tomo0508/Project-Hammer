using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjectHammer.Service.Interfaces
{
    /// <summary>
    /// Department  interface
    /// </summary>
    public interface IDepartment
    {
        /// <summary>
        /// Gets or sets DepartmentNo
        /// </summary>
        int DepartmentNo { get; set; }

        /// <summary>
        /// Gets or sets DepartmentName
        /// </summary>
        string DepartmentName { get; set; }

        /// <summary>
        /// Gets or sets DepartmenLocation
        /// </summary>
        string DepartmentLocation { get; set; }

        /// <summary>
        /// Gets or sets NumberOfEmployees
        /// </summary>
        int NumberOfEmployees { get; }

        ICollection<IEmployee> Employees { get; set; }


    }
}
