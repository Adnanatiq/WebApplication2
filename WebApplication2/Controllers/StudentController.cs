using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class StudentController : Controller
    {
        public ActionResult Student(int id)
        {
            var teacher = Helper.Helper.GetTeacher();
            var Student = Helper.Helper.GetStudentById(id);
            if (Student == null)
            {
                ViewBag.ErrorMessage = "Student not found.";
                return View();
            }
            else
            {
                ViewBag.Teacher = teacher;
                //ViewBag.Students = Student;

                return View(Student);
            }
        }

    }

}