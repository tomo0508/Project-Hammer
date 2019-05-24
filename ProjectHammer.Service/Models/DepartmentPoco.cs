using ProjectHammer.Service.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace ProjectHammer.Service.Models
{
   /// <summary>
   /// Department class
   /// </summary>
    public class DepartmentPoco : IDepartment
    {
        /// <summary>
        /// Gets or sets DepartmentNo
        /// </summary>
        public int DepartmentNo { get; set; }

        /// <summary>
        /// Gets or sets DepartmentName
        /// </summary>
        [Required(ErrorMessage = "Enter department name")]
        [StringLength(20, ErrorMessage = "Limit Department name to 20 characters.")]
        [Display(Name = "Department")]
        public string DepartmentName { get; set; }
        
        /// <summary>
        /// Gets or sets DepartmentLocation
        /// </summary>
        [Required(ErrorMessage = "Enter department  location")]
        [StringLength(20, ErrorMessage = "Limit department location to 20 characters.")]
        [Display(Name = "Location")]
        public string DepartmentLocation { get; set; }

       /// <summary>
       /// Gets or sets NumberOfEmployees
       /// </summary>
        [Display(Name = "Number of employees")]
        public int NumberOfEmployees { get; set; }

        public virtual ICollection<IEmployee> Employees { get; set; }
    }
}
