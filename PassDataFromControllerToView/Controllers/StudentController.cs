using PassDataFromControllerToView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PassDataFromControllerToView.Controllers
{
    public class StudentController : Controller
    {
        public ActionResult GetStudents()
        {
            var students = new List<Student>()
            {
                new Student()
                {
                    Id = 1,
                    Name = "John Smith",
                    Address = "London"
                },
                new Student()
                {
                    Id = 2,
                    Name = "Rock Smith",
                    Address = "Bucharest"
                },
                new Student()
                {
                    Id = 3,
                    Name = "Lora Angel",
                    Address = "Mumbai"
                }
            };

            return View(students);
        }
    }
}