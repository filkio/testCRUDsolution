using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using testCRUDsolution.Models;

namespace testCRUDsolution.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View(Repository.GetEmployeesFromDb());
        }


        [HttpGet]
        public ViewResult EmployeeAdd()
        {
            return View();
        }
        [HttpPost]
        public ViewResult EmployeeAdd(Employee employee)
        {
            if (ModelState.IsValid)
            {
                Repository.AddEmployee(employee);
                return View("CorrectForm");
            }
            else
            {
                return View();
            }
        }
    }
}
