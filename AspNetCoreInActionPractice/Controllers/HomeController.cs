using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreInActionPractice.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AspNetCoreInActionPractice.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployee _employeeRepo;

        public HomeController(IEmployee employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }
        public IActionResult Index()
        {
            IEnumerable<Employee> employee = _employeeRepo.GetEmployees();
            return View(employee);
        }

        public IActionResult Information(int? id)
        {
            Employee employee = _employeeRepo.SelectEmployee(id ?? 1);
            return View(employee);
        }

        public JsonResult CustomJson()
        {
            return Json(new { occupation = "Developer", name = "Dad S Wonkulah Jr" });
        }
    }
}
