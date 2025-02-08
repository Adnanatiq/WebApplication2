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
        public JsonResult AddStudent(Student model)
        {
            if (model.UserName == null || model.Email == null || model.Password == null || model.Reg_No == null ||
                model.Address == null || model.Phone_Number == null || model.Class == null)
            {
                return Json(new { success = false, message = "Please fill all the fields." });
            }

            // Add student to the database using Helper class
            bool isAdded = Helper.Helper.AddStudent(model);
            if (isAdded)
            {
                var students = Helper.Helper.GetStudent();
                ViewBag.Students = students;
                return Json(new { success = true, message = "Student added successfully." });
            }
            else
            {
                return Json(new { success = false, message = "Failed to add student. Please try again." });
            }
        }

        [HttpGet]
        public JsonResult GetStudentById(int id)
        {
            var student = Helper.Helper.GetStudentById(id);
            if (student != null)
            {
                return Json(new { success = true, student = student }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { success = false, message = "Student not found." }, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public JsonResult DeleteStudentbyId(int id)
        {
            bool result = Helper.Helper.DeleteStudentbyId(id);
            if (result)
            {
                return Json(new { success = true, message = "Student deleted successfully." });
            }
            else
            {
                return Json(new { success = false, message = "Failed to delete student." });
            }
        }

    }
}