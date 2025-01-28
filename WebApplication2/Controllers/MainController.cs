using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class MainController : Controller
    {
        public ActionResult Main_Page(int id)
        {
            var teacher = Helper.Helper.GetTeacherById(id);
            var Student = Helper.Helper.GetStudent();
            if (teacher == null)
            {
                ViewBag.ErrorMessage = "Teacher not found.";
                return View();
            }
            else
            {
                ViewBag.Teacher = teacher;
                ViewBag.Students = Student;

                return View();
            }
        }

        [HttpPost]
        public ActionResult AddStudent(Student Model)
        {
            if (Model.UserName == null || Model.Email == null || Model.Password == null || Model.Reg_No == null || Model.Address == null || Model.Phone_Number == null || Model.Class == null)
            {
                ViewBag.ErrorMessage = "Plz Fill All The Filed";
                //return RedirectToAction("Main_Page");
            }
            else
            {
                Console.WriteLine(Model);

            }
            return View();
        }

    }
}