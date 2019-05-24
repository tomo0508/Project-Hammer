using ProjectHammer.Service.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectHammer.Service.Models
{
    /// <summary>
    /// Employee class
    /// </summary>
    public class EmployeePoco : IEmployee
    {     
        /// <summary>
        /// Gets or sets employeeNo
        /// </summary>
        public int EmployeeNo { get; set; }
        
        /// <summary>
        /// Gets or sets EmployeName
        /// </summary>
        [Required(ErrorMessage = "Enter employee name")]
        [StringLength(50, ErrorMessage = "Limit User name to 50 characters.")]
        public string EmployeeName { get; set; }

        /// <summary>
        /// Gets or sets Salary
        /// </summary>
        [Display(Name = "Salary")]
        public float Salary { get; set; }

        /// <summary>
        /// Gets or sets DepartmentNo
        /// </summary>
        [Display(Name = "Department number")]
        public int DepartmentNo { get; set; }

        /// <summary>
        /// Gets or sets Department of employee
        /// </summary>
        public virtual IDepartment Department { get; set; }

        /// <summary>
        /// Gets or sets Date
        /// </summary>
        [Display(Name = "Updated")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime LastModifyDate { get; set; }
    }
}
