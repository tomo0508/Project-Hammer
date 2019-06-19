using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectHammer.Service.Interfaces;
using ProjectHammer.Service.Models;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectHammer.Web.Controllers
{
    [Authorize]
    public class DepartmentController : Controller
    {
        private readonly IEmployeeService employeeService;
        private readonly IService<IDepartment> service;
        private readonly IDepartmentService departmentService;
        private readonly IMapper mapper;


        public DepartmentController(IEmployeeService employeeService, IService<IDepartment> service, IDepartmentService departmentService, IMapper mapper)
        {

            this.employeeService = employeeService;
            this.service = service;
            this.departmentService = departmentService;
            this.mapper = mapper;


        }

        // GET: Department
        public async Task<IActionResult> Index()
        {
            var departments = await departmentService.GetDepartments();

            var developmentEmployees = await departmentService.GetDevelopmentEmployees();
            var departmentsWithMoreEmployees = await departmentService.GetDepartmentEmployees();

            var departmentsView = await departmentService.GetDepartmentsView();

            ViewBag.DevelopmentDepartment = developmentEmployees;
            ViewBag.Departments = departmentsWithMoreEmployees;
            ViewBag.DepartmentsView = departmentsView;

            return View(departments);
        }

        // GET: Department/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var department = await departmentService.GetDepartments();

            var departmentToReturn = department
                .FirstOrDefault(m => m.DepartmentNo == id);
            if (department == null)
            {
                return NotFound();
            }

            return View(departmentToReturn);
        }

        // GET: Department/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Department/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DepartmentNo,DepartmentName,DepartmentLocation")] DepartmentPoco department)
        {
            if (ModelState.IsValid)
            {
                await service.Add(department);
                return RedirectToAction(nameof(Index));
            }
            return View(department);
        }

        // GET: Department/Edit/5
        public async Task<IActionResult> Edit(int id)
        {

            var department = await departmentService.GetDepartment(id);
            if (department == null)
            {
                return NotFound();
            }
            return View(department);
        }

        // POST: Department/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DepartmentNo,DepartmentName,DepartmentLocation")] DepartmentPoco department)
        {
            if (id != department.DepartmentNo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await service.Update(department);

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DepartmentExists(department.DepartmentNo))
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
            return View(department);
        }

        // GET: Department/Delete/5
        public async Task<IActionResult> Delete(int id)
        {

            var department = await departmentService.GetDepartment(id);

            if (department == null)
            {
                return NotFound();
            }

            return View(department);
        }

        // POST: Department/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {

            var departmentToDelete = await departmentService.GetDepartment(id);
            await service.Delete(departmentToDelete);

            return RedirectToAction(nameof(Index));
        }

        private bool DepartmentExists(int id)
        {

            return departmentService.GetDepartments().Result.Any(e => e.DepartmentNo == id);
        }
    }
}
