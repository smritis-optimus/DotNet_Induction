using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
namespace Assignment26
{
    public class Student
    {
        private int _rollno;
        private string _name;
        private char _gender;
        private int _age;
        private string _stream;

        public int RollNo
        {
            get
            {
                return _rollno;
            }
            set
            {
                _rollno = value;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public char Gender
        {
            get
            {
                return _gender;
            }
            set
            {
                _gender = value;
            }
        }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }
        public string Stream
        {
            get
            {
                return _stream;
            }
            set
            {
                _stream = value;
            }
        }
        public static bool insertStudents(List<Student> students)
        {
            SqlConnection con;
            SqlCommand cmd;
            string connection = ConfigurationManager.ConnectionStrings["StudentDB"].ConnectionString;
            try
            {
                //every record of the student list is taken and inserted in the database.
                //Query is executed for insertion of every record
                foreach (Student student in students)
                {
                    string query = "insert into Student values('" + student.RollNo + "','" + student.Name + "','" + student.Gender + "','" + student.Age + "','" + student.Stream + "')";
                    using (con = new SqlConnection(connection))
                    {
                        using (cmd = new SqlCommand(query, con))
                        {
                            con.Open();
                            cmd.ExecuteNonQuery();
                        }
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