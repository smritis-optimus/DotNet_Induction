using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LMS.DataAccess;
namespace LMS.PresentationUI
{
    public partial class StudentsDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                BindGridview();
        }
        /// <summary>
        /// method to load all the students in the gridview
        /// </summary>
        protected void BindGridview()
        {
            gvStudentDetails.DataSource = StudentsOperations.GetStudents();
            gvStudentDetails.DataBind();
        }
        /// <summary>
        /// method to make the row editable on click of edit label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void GvStudentRowEditing(object sender, GridViewEditEventArgs e)
        {
            gvStudentDetails.EditIndex = e.NewEditIndex;
            BindGridview();
        }
        /// <summary>
        /// method to make the label back to non editing mode on click of cancel label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void GvStudentRowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvStudentDetails.EditIndex = -1;
            BindGridview();
        }
        /// <summary>
        /// method to take the updated values from textbox and send it to IsUpdate method fro updation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void GvStudentRowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string username = (gvStudentDetails.Rows[e.RowIndex].FindControl("lblUsername") as Label).Text;
            string password = (gvStudentDetails.Rows[e.RowIndex].FindControl("txtPassword") as TextBox).Text;
            string name = (gvStudentDetails.Rows[e.RowIndex].FindControl("txtName") as TextBox).Text;
            int age = Convert.ToInt32((gvStudentDetails.Rows[e.RowIndex].FindControl("txtAge") as TextBox).Text);
            string gender = (gvStudentDetails.Rows[e.RowIndex].FindControl("txtGender") as TextBox).Text;
            int rollno = Convert.ToInt32((gvStudentDetails.Rows[e.RowIndex].FindControl("txtRollno") as TextBox).Text);
            string branch = (gvStudentDetails.Rows[e.RowIndex].FindControl("txtBranch") as TextBox).Text;
            if (StudentsOperations.IsUpdateStudent(username, password, name, age, gender, rollno, branch))
            { }
            else
                Response.Write("<script>alert('unable to update');</script>");
            BindGridview();
        }
        /// <summary>
        /// method to select the particular username and send that username to delete method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void GvStudentRowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string username = ((gvStudentDetails.Rows[e.RowIndex].FindControl("lblUsername") as Label).Text);
            StudentsOperations.DeleteStudent(username);
            BindGridview();
        }
        /// <summary>
        /// method to take the values from textbox and send those values to insert in student databse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void GvStudentSelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox Username = (TextBox)gvStudentDetails.FooterRow.FindControl("txtAddUsername");
            TextBox Password = (TextBox)gvStudentDetails.FooterRow.FindControl("txtAddPassword");
            TextBox Name = (TextBox)gvStudentDetails.FooterRow.FindControl("txtAddName");
            TextBox Age = (TextBox)gvStudentDetails.FooterRow.FindControl("txtAddAge");
            TextBox Gender = (TextBox)gvStudentDetails.FooterRow.FindControl("txtAddGender");
            TextBox Rollno = (TextBox)gvStudentDetails.FooterRow.FindControl("txtAddRollno");
            TextBox Branch = (TextBox)gvStudentDetails.FooterRow.FindControl("txtAddBranch");
            StudentsOperations.AddStudent(Username.Text, Password.Text, Name.Text, Convert.ToInt32(Age.Text), Gender.Text, Convert.ToInt32(Rollno.Text), Branch.Text);
            BindGridview();
        }

    }
}