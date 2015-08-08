using System;
using LMS.DataAccess;
namespace LMS.PresentationUI
{
    public partial class StudentRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// method to take values from textbox which is entered by user
        /// and send those values to AddStudent function to add student to database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnCreate_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            //if username already exits,choose a different username
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