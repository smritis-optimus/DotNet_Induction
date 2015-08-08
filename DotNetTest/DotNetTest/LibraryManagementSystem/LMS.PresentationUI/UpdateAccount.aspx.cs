using System;
using LMS.DataAccess;
namespace LMS.PresentationUI
{
    public partial class UpdateAccount : System.Web.UI.Page
    {
        /// <summary>
        /// on page load,the old entirs from student table is displayed in textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string currentUser = Session["username"].ToString();
                Student currentStudent = new Student();
                currentStudent = StudentsOperations.GetUser(currentUser);
                txtAge.Text = currentStudent.Age.ToString();
                txtBranch.Text = currentStudent.Branch;
                txtGender.Text = currentStudent.Gender;
                txtName.Text = currentStudent.Name;
                txtPassword.Text = currentStudent.Password;
                txtRollNo.Text = currentStudent.Rollno.ToString();
            }
        }
        /// <summary>
        /// method to take the updated values from texbox and send to Update method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            string currentUser = Session["username"].ToString();
            string password = txtPassword.Text;
            string name = txtName.Text;
            int age = Convert.ToInt32(txtAge.Text);
            string gender = txtGender.Text;
            int rollno = Convert.ToInt32(txtRollNo.Text);
            string branch = txtBranch.Text;
            if (StudentsOperations.IsUpdateStudent(currentUser, password, name, age, gender, rollno, branch))
            {
                //Response.Write("<script>alert('Record Updated');</script>");
                //txtPassword.Text = "";
                //txtAge.Text = "";
                //txtBranch.Text = "";
                //txtGender.Text = "";
                //txtName.Text = "";
                //txtRollNo.Text = "";
            }
        }
    }
}