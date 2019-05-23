using System;

namespace ProjectHammer.DAL.Entities
{
    public class Employee
    {
        /// <summary>
        /// Gest or sets EmployeeNo.
        /// </summary>      
        public int EmployeeNo { get; set; }

        /// <summary>
        /// Gest or sets EmployeeName.
        /// </summary>    
        public string EmployeeName { get; set; }

        /// <summary>
        /// Gest or sets Salary.
        /// </summary>
        public float Salary { get; set; }

        /// <summary>
        /// Gest or sets employee department.
        /// </summary>      
        public int DepartmentNo { get; set; }

        /// <summary>
        /// Gest or sets employee department.
        /// </summary>        
        public virtual Department Department { get; set; }

        /// <summary>
        /// Gest or sets LastModifiyDate.
        /// </summary>
        public DateTime LastModifyDate
        {
            get
            {
                return this.lastModifyDate.HasValue
                   ? this.lastModifyDate.Value
                   : DateTime.Now;
            }

            set { this.lastModifyDate = value; }
        }

        private DateTime? lastModifyDate = null;





    }
}
