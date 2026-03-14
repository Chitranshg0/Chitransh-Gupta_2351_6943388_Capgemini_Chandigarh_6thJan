using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Assessment.Data;
using Assessment.Models;

namespace Assessment.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly AppDbContext _context;

        public EmployeeController(AppDbContext context)
        {
            _context = context;
        }

        // SHOW EMPLOYEES
        public IActionResult Index()
        {
            var employees = _context.Employees
                .Include(e => e.Department)
                .ToList();

            return View(employees);
        }

        // LOAD CREATE PAGE
        public IActionResult Create()
        {
            ViewBag.Departments = _context.Departments.ToList();
            ViewBag.Projects = _context.Projects.ToList();
            return View();
        }

        // SAVE EMPLOYEE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Employee employee, int[] projectIds)
        {
            if (ModelState.IsValid)
            {
                _context.Employees.Add(employee);
                _context.SaveChanges();

                // Save selected projects
                if (projectIds != null)
                {
                    foreach (var pid in projectIds)
                    {
                        EmployeeProject ep = new EmployeeProject
                        {
                            EmployeeId = employee.EmployeeId,
                            ProjectId = pid,
                            AssignedDate = DateTime.Now
                        };

                        _context.EmployeeProjects.Add(ep);
                    }

                    _context.SaveChanges();
                }

                return RedirectToAction("Index");
            }

            // Reload dropdown data if validation fails
            ViewBag.Departments = _context.Departments.ToList();
            ViewBag.Projects = _context.Projects.ToList();

            return View(employee);
        }
    }
}