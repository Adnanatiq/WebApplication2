using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Dapper;
using WebApplication2.Models;

namespace WebApplication2.Helper
{
    public class Helper
    {
        private static string connection = System.Configuration
            .ConfigurationManager.ConnectionStrings["Db_Connect"].ConnectionString;

        private static SqlConnection GetConnection()
        {
            return new SqlConnection(connection);
        }

        //******************** Teacher Data *************************

        public static List<Teacher> GetTeacher()
        {
            try
            {
                using (var db = GetConnection())
                {
                    string qry = "SELECT * FROM Teacher_data";
                    return db.Query<Teacher>(qry).ToList();
                }
            }
            catch (Exception ex)
            {
                // Log or display the error
                Console.WriteLine(ex.Message);
                return new List<Teacher>();
            }
        }

        public static Teacher GetTeacherById(int id)
        {
            try
            {
                using (var db = GetConnection())
                {
                    string qry = "SELECT * FROM Teacher_data WHERE id = @Id";
                    return db.QueryFirstOrDefault<Teacher>(qry, new { Id = id });
                }
            }
            catch (Exception ex)
            {
                // Log or display the error
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        //************************* Student *******************************

        public static List<Student> GetStudent()
        {
            try
            {
                using (var db = GetConnection())
                {
                    string qry = "SELECT * FROM Student_Data";
                    return db.Query<Student>(qry).ToList();
                }
            }
            catch (Exception ex)
            {
                // Log or display the error
                Console.WriteLine(ex.Message);
                return new List<Student>();
            }
        }

        public static Student GetStudentById(int id)
        {
            try
            {
                using (var db = GetConnection())
                {
                    string qry = "SELECT * FROM Student_Data WHERE id = @id";
                    return db.QueryFirstOrDefault<Student>(qry, new { id = id });
                }
            }
            catch (Exception ex)
            {
                // Log or display the error
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public static bool AddStudent(Student student)
        {
          try
          {
            using (var db = GetConnection())
            {
                string qry = @"
                 INSERT INTO Student_Data (UserName, Email, Password, Reg_No, Address, Class, Phone_Number, Status)
                 VALUES (@UserName, @Email, @Password, @Reg_No, @Address, @Class, @Phone_Number, @Status)";

                 var result = db.Execute(qry, student);

               return result > 0; // returns true if the insertion was successful
            }
          }
          catch (Exception ex)
          {
             // Log or display the error
             Console.WriteLine(ex.Message);
             return false;
          }
        }

        public static bool DeleteStudentbyId(int id)
        {
            try
            {
                using (var db = GetConnection())
                {
                    string qry = "DELETE FROM Student_Data WHERE id = @id";

                    var result = db.Execute(qry, new { id = id });

                    return result > 0; // Returns true if deletion was successful
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

    }
}
