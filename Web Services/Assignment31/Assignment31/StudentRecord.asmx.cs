using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
namespace Assignment31
{
    /// <summary>
    /// Summary description for StudentRecord
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class StudentRecord : System.Web.Services.WebService
    {
        //<summary>
        //method for creating connection with database and retrieving student information using stored procedure
        //</summary>
        [WebMethod]
        public Student GetStudentByID(int Id)
        {
            string connection = ConfigurationManager.ConnectionStrings["StudentDB"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand("spGetStudentById", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter parameter = new SqlParameter("@ID", Id);
                    cmd.Parameters.Add(parameter);
                    Student student = new Student();
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        student.Id = Convert.ToInt32(dr["RollNo"]);
                        student.Name = dr["Name"].ToString();
                        student.Gender = (dr["Gender"]).ToString();
                        student.Age = Convert.ToInt32(dr["Age"]);
                        student.Stream = dr["Stream"].ToString();
                    }
                    return student;
                }
            }
        }
    }
}
