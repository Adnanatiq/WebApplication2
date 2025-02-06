using System.Web.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Login(string Email, string Password, string Selection)
        {
            // Process the login logic
            var teachers = Helper.Helper.GetTeacher();
            var students = Helper.Helper.GetStudent();
            bool flag = false;
            int id = 0;
            foreach (var t in teachers)
            {
                if (t.Email.Trim() == Email.Trim() && t.Password.Trim() == Password.Trim())
                {
                    id = t.id;
                    flag = true;
                    break;
                }
            }
            foreach (var s in students)
            {
                if (s.Email.Trim() == Email.Trim() && s.Password.Trim() == Password.Trim())
                {
                    id = s.id;
                    flag = true;
                    break;
                }
            }

            if (Selection == "Teacher")
            {
                if (flag == true)
                {
                    return RedirectToAction("Main_page", "Main", new { id = id });
                }
            }
            else
            {
                if (flag == true)
                {
                    return RedirectToAction("Student", "Student", new { id = id });
                }
            }
            ViewBag.ErrorMessage = "Invalid email or password.";
            return View();
        }
    }
}