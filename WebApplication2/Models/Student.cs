using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Student
    {
        public int id { get; set; }

        public string UserName { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }

        public string Address { get; set; }

        public string Class { get; set; }

        public string Status { get; set; }

        public string Reg_No { get; set; }

        public string Phone_Number { get; set; }

    }
}