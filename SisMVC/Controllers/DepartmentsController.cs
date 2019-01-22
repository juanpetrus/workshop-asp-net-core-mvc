using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SisMVC.Models;

namespace SisMVC.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department { Id = 1, Name = "Juan Petrus" });
            list.Add(new Department { Id = 2, Name = "Newton SErgio" });

            return View(list);
        }
    }
}