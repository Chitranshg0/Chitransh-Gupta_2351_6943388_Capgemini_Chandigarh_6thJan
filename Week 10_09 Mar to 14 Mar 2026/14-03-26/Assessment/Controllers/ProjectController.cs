using Microsoft.AspNetCore.Mvc;
using Assessment.Data;
using Assessment.Models;
using Microsoft.EntityFrameworkCore;

namespace Assessment.Controllers
{
    public class ProjectController : Controller
    {
        private readonly AppDbContext _context;

        public ProjectController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var projects = _context.Projects.ToList();
            return View(projects);
        }

        public IActionResult Create()
        {
            ViewBag.Employees = _context.Employees.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Project project, int[] employeeIds)
        {
            _context.Projects.Add(project);
            _context.SaveChanges();

            foreach (var eid in employeeIds)
            {
                EmployeeProject ep = new EmployeeProject
                {
                    EmployeeId = eid,
                    ProjectId = project.ProjectId,
                    AssignedDate = DateTime.Now
                };

                _context.EmployeeProjects.Add(ep);
            }

            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}