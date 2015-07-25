using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;

namespace Ado.netAssignment
{
    public class StudentDataHandler
    {
        private int _id;
        private string _name;
        private int _age;
        private string _stream;
        private string _state;
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
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
        public string State
        {
            get
            {
                return _state;
            }
            set
            {
                _state = value;
            }

        }

        public string connection;

        public StudentDataHandler()
        {
            try
            {
                connection = ConfigurationManager.ConnectionStrings["StudentDB"].ConnectionString;

                SqlConnection con = new SqlConnection(connection);
            }
            catch (SqlException ex)
            {
                
            }
        }
        public bool AddStudent()
        {

            SqlConnection con = new SqlConnection(connection);
            try
            {

                string query = "insert into Student values('" + Id + "','" + Name + "','" + Age + "',(select Name from Stream where Id='" + Convert.ToInt32(Stream) + "'),(select Name from State where Id='" + Convert.ToInt32(State) + "'))";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
         
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
              
            }
            catch (SqlException ex)
            {
                return false;
            }
            finally
            {
                con.Close();
            }

        }
        public bool UpdateStudents()
        {
            SqlConnection con = new SqlConnection(connection);
            try
            {

                string query = "update Student set Name='" + Name + "',Age='" + Age + "',Stream=(select Name from Stream where Id='" + Convert.ToInt32(Stream) + "'),State=(select Name from State where Id='" + Convert.ToInt32(State) + "')where Id='"+Id+"'";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (SqlException ex)
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public List<Student> GetAllStudents(int streamID)
        {
            List<Student> students = new List<Student>();
            Student s1;
            SqlConnection con = new SqlConnection(connection);
            try
            {
                string query = "Select Student.Id,Student.Name,Student.Age,Student.Stream,Student.State,Stream.Id from Student join Stream on Student.Stream=Stream.Name where Stream.Id=" + streamID;
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    s1 = new Student();
                    s1.Id = Convert.ToInt32(dr["Id"]);
                    s1.Name = dr["Name"].ToString();
                    s1.Age = Convert.ToInt32(dr["Age"]);
                    s1.Stream = dr["Stream"].ToString();
                    s1.State = dr["State"].ToString();
                    students.Add(s1);
                }
                dr.Close();
                return students;
            }
            catch (SqlException ex)
            {
                return null;
            }
            finally
            {
                con.Close();
              
            }
        }

        public List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>();
            Student s1;
            SqlConnection con = new SqlConnection(connection);
            try
            {
                string query = "Select * from Student";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    s1 = new Student();
                    s1.Id = Convert.ToInt32(dr["Id"]);
                    s1.Name = dr["Name"].ToString();
                    s1.Age = Convert.ToInt32(dr["Age"]);
                    s1.Stream = dr["Stream"].ToString();
                    s1.State = dr["State"].ToString();
                    students.Add(s1);
                }
                dr.Close();
                return students;
            }
            catch (SqlException ex)
            {
                return null;
            }
            finally
            {
                con.Close();

            }
        }

       
        public Student GetStudent(int id)
        {
            Student student = null;
            string query = "select Id,Name,Age,Stream,State from Student where Id=" + id;
            SqlConnection con = new SqlConnection(connection);
            try
            { SqlCommand cmd = new SqlCommand(query, con);
               con.Open();

               SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    student = new Student();
                    student.Id = Convert.ToInt32(dr["Id"]);
                    student.Name =dr["Name"].ToString();
                    student.Age = Convert.ToInt32(dr["Age"]);
                    student.Stream = dr["Stream"].ToString();
                    student.State = dr["State"].ToString();
                    return student;
                }
                else
                    return null;
            }
            catch (SqlException ex)
            {
                return null;
            }
            finally
            {
               con.Close();
            }
        }
        public bool DeleteStudents(string id)
        {
            string query = "delete from Student where Id in(" + Id + ")";
            SqlConnection con = new SqlConnection(connection);
            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (SqlException ex)
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }
    }
}