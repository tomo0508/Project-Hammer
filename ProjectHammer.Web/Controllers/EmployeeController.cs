using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjectHammer.DAL;
using ProjectHammer.Service.Interfaces;
using ProjectHammer.Service.Models;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHammer.Web.Controllers
{
    [Authorize]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService employeeService;
        private readonly IService<IEmployee> service;
        private readonly IDepartmentService departmentService;
        private readonly IMapper mapper;


        public EmployeeController(IEmployeeService employeeService, IService<IEmployee> service, IDepartmentService departmentService, IMapper mapper, CompanyContext context)
        {

            this.employeeService = employeeService;
            this.service = service;
            this.departmentService = departmentService;
            this.mapper = mapper;

        }

        // GET: Employees
        public async Task<IActionResult> Index()
        {
            var employees = await employeeService.GetEmployees();
            //var employeesToReturn = mapper.Map<IEnumerable<EmployeeViewModel>>(employees);
            ViewBag.AverageSalary = employeeService.AverageSalary();
            ViewBag.SecondHighestSalary = employeeService.SecondHighestSalary();

            return View(employees);
        }

        // GET: Employees/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var employee = await employeeService.GetEmployee(id);
            //var employeeToReturn = mapper.Map<EmployeeViewModel>(employee);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // GET: Employees/Create
        public async Task<IActionResult> Create()
        {
            ViewData["DepartmentNo"] = new SelectList(await departmentService.GetDepartments(), "DepartmentNo", "DepartmentLocation");
            return View();
        }

        // POST: Employees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EmployeeNo,EmployeeName,Salary,DepartmentNo")] EmployeePoco employee)
        {
            if (ModelState.IsValid)
            {

                await service.Add(employee);
                return RedirectToAction(nameof(Index));
            }
            ViewData["DepartmentNo"] = new SelectList(await departmentService.GetDepartments(), "DepartmentNo", "DepartmentLocation", employee.DepartmentNo);
            return View(employee);
        }

        // GET: Employees/Edit/5
        public async Task<IActionResult> Edit(int id)
        {


            var employee = await employeeService.GetEmployee(id);
            // var employeeToReturn = mapper.Map<EmployeeViewModel>(employee);

            if (employee == null)
            {
                return NotFound();
            }
            ViewData["DepartmentNo"] = new SelectList(await departmentService.GetDepartments(), "DepartmentNo", "DepartmentLocation", employee.DepartmentNo);
            return View(employee);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EmployeeNo,EmployeeName,Salary,DepartmentNo,LastModifyDate")] EmployeePoco employee)
        {
            //var employeeToEdit = mapper.Map<EmployeePoco>(employee);

            if (id != employee.EmployeeNo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await service.Update(employee);

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeExists(employee.EmployeeNo))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["DepartmentNo"] = new SelectList(await departmentService.GetDepartments(), "DepartmentNo", "DepartmentLocation", employee.DepartmentNo);
            return View(employee);
        }

        // GET: Employees/Delete/5
        public async Task<IActionResult> Delete(int id)
        {

            var employee = await employeeService.GetEmployee(id);

            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employeeToDelete = await employeeService.GetEmployee(id);
            await service.Delete(employeeToDelete);

            return RedirectToAction(nameof(Index));
        }



        public FileStreamResult CreateFile()
        {
            string employeesAsText = employeeService.ExportEmployees();

            var byteArray = Encoding.ASCII.GetBytes(employeesAsText);
            var stream = new MemoryStream(byteArray);

            return File(stream, "text/plain", "Employees.txt");
        }


        public IActionResult EditSalary()
        {

            return RedirectToAction("Salary", "Employee");
        }

        public IActionResult Salary()
        {

            return View();
        }

        [HttpPost]
        public ActionResult ChangeSalary(int employeeNo, int salaryPercent)
        {

            employeeService.ChangeSalary(employeeNo, salaryPercent);

            return RedirectToAction(nameof(Index));

        }

        private bool EmployeeExists(int id)
        {
            return employeeService.GetEmployees().Result.Any(e => e.EmployeeNo == id); ;
        }
    }


}
