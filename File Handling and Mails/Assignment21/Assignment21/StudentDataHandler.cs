using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;

namespace Assignment21
{
    public class StudentDataHandler
    {

        public static bool insertStudents(List<Student> studentsData)
        {
            SqlConnection con;
            SqlCommand cmd;
            string connection = ConfigurationManager.ConnectionStrings["StudentDB"].ConnectionString;
            try
            {
                //every record of the student list is taken and inserted in the database.
                //Query is executed for insertion of every record
                foreach (Student student in studentsData)
                {
                    string query = "insert into Student values('" + student.RollNo + "','" + student.Name + "','" + student.Gender + "','" + student.Age + "','" + student.Stream + "')";
                    using (con = new SqlConnection(connection))
                    {
                        cmd = new SqlCommand(query, con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}