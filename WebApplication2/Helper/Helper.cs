﻿using System;
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
                    string qry = "SELECT * FROM Student_Data WHERE id = @Id";
                    return db.QueryFirstOrDefault<Student>(qry, new { Id = id });
                }
            }
            catch (Exception ex)
            {
                // Log or display the error
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}