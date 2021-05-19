using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;

namespace SalesWebMvc.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> Departments = new List<Department>();
            Departments.Add(new Department { Id = 1, Name = "Garagem" });
            Departments.Add(new Department { Id = 2, Name = "Elétrica" });
            Departments.Add(new Department { Id = 3, Name = "Oficina" });

            return View(Departments);
        }
    }
}
