using ProjectHammer.Service.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectHammer.Service.Models
{

    public class EmployeePoco : IEmployee
    {     
        public int EmployeeNo { get; set; }

        [Required(ErrorMessage = "Enter employee name")]
        [StringLength(50, ErrorMessage = "Limit User name to 50 characters.")]
        public string EmployeeName { get; set; }

        [Display(Name = "Salary")]
        public float Salary { get; set; }

        [Display(Name = "Department number")]
        public int DepartmentNo { get; set; }

        public virtual IDepartment Department { get; set; }

        [Display(Name = "Updated")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime LastModifyDate { get; set; }
    }
}
