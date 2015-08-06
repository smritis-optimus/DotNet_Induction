using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LMS.DataAccess;
namespace LMS.PresentationUI
{
    public partial class UpdateAccount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string currentUser = Session["username"].ToString();
            Student currentStudent = new Student();
            currentStudent=StudentsOperations.ViewUser(currentUser);
            txtAge.Text = currentStudent.Age.ToString();
            txtBranch.Text = currentStudent.Branch;
            txtGender.Text = currentStudent.Gender;
            txtName.Text = currentStudent.Name;
            txtPassword.Text = currentStudent.Password;
            txtRollNo.Text = currentStudent.Rollno.ToString();
        }
        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            string currentUser = Session["username"].ToString();
            string password = txtPassword.Text;
            string name = txtName.Text;
            int age = Convert.ToInt32(txtAge.Text);
            string gender = txtGender.Text;
            int rollno = Convert.ToInt32(txtRollNo.Text);
            string branch = txtBranch.Text;
            if(StudentsOperations.IsUpdateStudent(currentUser, password, name, age, gender, rollno, branch))
                Response.Write("<script>alert('Record Updated');</script>");
            txtPassword.Text = "";
            txtAge.Text = "";
            txtBranch.Text = "";
            txtGender.Text = "";
            txtName.Text = "";
            txtRollNo.Text = "";
        }
    }
}