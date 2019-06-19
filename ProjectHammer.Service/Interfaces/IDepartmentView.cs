using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectHammer.Service.Interfaces
{
  public  interface IDepartmentView
    {
        int DepartmentNo { get; set; }
        string DepartmentDescription { get; set; }
    }
}
