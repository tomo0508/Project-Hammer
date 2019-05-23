using ProjectHammer.Service.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace ProjectHammer.Service.Models
{
   
    public class DepartmentPoco : IDepartment
    {
        
        public int DepartmentNo { get; set; }

        
        [Required(ErrorMessage = "Enter department name")]
        [StringLength(20, ErrorMessage = "Limit Department name to 20 characters.")]
        [Display(Name = "Department")]
        public string DepartmentName { get; set; }
        
        [Required(ErrorMessage = "Enter department  location")]
        [StringLength(20, ErrorMessage = "Limit department location to 20 characters.")]
        [Display(Name = "Location")]
        public string DepartmentLocation { get; set; }

       
        [Display(Name = "Number of employees")]
        public int NumberOfEmployees { get; set; }

        public virtual ICollection<IEmployee> Employees { get; set; }
    }
}
