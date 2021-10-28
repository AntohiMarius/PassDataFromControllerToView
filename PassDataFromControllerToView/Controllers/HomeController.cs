using PassDataFromControllerToView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PassDataFromControllerToView.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.FirstName = "Marius";
            ViewBag.LastName = "Antohi";
            ViewBag.Address = "antohi.marius11@gmail.com";
            return View();
        }

        public ActionResult GetEmployee()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee()
                {
                    EmployeeID = 1,
                    EmployeeName = "Marius Antohi",
                    DateOfJoining = System.DateTime.Now,
                    MartialStatus = 1,
                    IsEligibleForLoan = true,
                    Salary = 15000.00m,
                    CreatedBy = "Admin",
                    CreatedDate = System.DateTime.Now
                },
                new Employee()
                {
                    EmployeeID = 2,
                    EmployeeName = "Ihutiu Bogdan",
                    DateOfJoining = System.DateTime.Now,
                    MartialStatus = 1,
                    IsEligibleForLoan = true,
                    Salary = 15000.00m,
                    CreatedBy = "Admin",
                    CreatedDate = System.DateTime.Now
                },
                new Employee()
                {
                    EmployeeID = 3,
                    EmployeeName = "Pripici Stefan",
                    DateOfJoining = System.DateTime.Now,
                    MartialStatus = 1,
                    IsEligibleForLoan = true,
                    Salary = 15000.00m,
                    CreatedBy = "Admin",
                    CreatedDate = System.DateTime.Now
                },
                new Employee()
                {
                    EmployeeID = 4,
                    EmployeeName = "Florin Straton",
                    DateOfJoining = System.DateTime.Now,
                    MartialStatus = 1,
                    IsEligibleForLoan = true,
                    Salary = 15000.00m,
                    CreatedBy = "Admin",
                    CreatedDate = System.DateTime.Now
                }
            };

            ViewBag.Employees = employees;
            return View();
        }
    }
}