using System.Collections.Generic;

namespace ProjectHammer.DAL.Entities
{

    public class Department
    {
        /// <summary>
        /// Gest or sets DepartmentNo.
        /// </summary>       
        public int DepartmentNo { get; set; }

        /// <summary>
        /// Gest or sets DepartmentName.
        /// </summary>        
        public string DepartmentName { get; set; }

        /// <summary>
        /// Gest or sets DepartmentLocation.
        /// </summary>      
        public string DepartmentLocation { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
