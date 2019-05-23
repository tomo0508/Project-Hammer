using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProjectHammer.Service.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjectHammer.Web.WebApi
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
       
        private readonly IService<IEmployee> employeeService;
        private readonly IService<IDepartment> departmentService;
        private readonly IMapper mapper;

        public CompanyController(IService<IEmployee> employeeService, IService<IDepartment> departmentService, IMapper mapper)
        {

            this.employeeService = employeeService;
            this.departmentService = departmentService;
            this.mapper = mapper;

        }
        [HttpGet("employees")]
        public async Task<ActionResult<IEnumerable<IEmployee>>> GetEmployees()
        {
            var employees = await employeeService.GetApi();          
            return Ok(employees);
        }

        [HttpGet("departments")]
        public async Task<ActionResult<IEnumerable<IDepartment>>> GetDepartments()
        {
            var departments = await departmentService.GetApi();
            return Ok(departments);
        }
    }
}