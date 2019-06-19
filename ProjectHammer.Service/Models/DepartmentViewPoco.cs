using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProjectHammer.Service.Models
{
  public  class DepartmentViewPoco
    {
        /// <summary>
        /// Gets or sets DepartmentNo
        /// </summary>
        public int DepartmentNo { get; set; }

        /// <summary>
        /// Gets or sets DepartmentName
        /// </summary>      
        public string DepartmentDescription { get; set; }
    }
}
