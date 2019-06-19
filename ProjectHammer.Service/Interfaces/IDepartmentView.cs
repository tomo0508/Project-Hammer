using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectHammer.Service.Interfaces
{
    /// <summary>
    /// Department view interface
    /// </summary>
  public  interface IDepartmentView
    {
        /// <summary>
        /// Gets or sets Department No
        /// </summary>
        int DepartmentNo { get; set; }

        /// <summary>
        /// Gets or sets Department location
        /// </summary>
        string DepartmentDescription { get; set; }
    }
}
