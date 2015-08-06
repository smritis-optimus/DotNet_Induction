using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LMS.DataAccess;
namespace LMS.PresentationUI
{
    public partial class StudentRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void BtnCreate_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            if (StudentsOperations.IsUser(username))
                Response.Write("<script>alert('Username not available.choose a different username');</script>");
            else
            {
                string password = txtPassword.Text;
                string name = txtName.Text;
                int age = Convert.ToInt32(txtAge.Text);
                string gender = txtGender.Text;
                int rollno = Convert.ToInt32(txtRollNo.Text);
                string branch = txtBranch.Text;
                StudentsOperations.AddStudent(username, password, name, age, gender, rollno, branch);
                Response.Write("<script>alert('Student Added');</script>");
                txtPassword.Text = "";
                txtAge.Text= "";
                txtBranch.Text = "";
                txtGender.Text = "";
                txtName.Text = "";
                txtRollNo.Text = "";
                txtUsername.Text = "";
            }
        }
    }
}