using System;
using LMS.DataAccess;
namespace LMS.PresentationUI
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// check login credintials is valid or not
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            string userType = ddlUser.SelectedValue;//get the specified usertype from login
            if (userType.Equals("Admin"))
            {
                if (ValidLogin.IsAdmin(txtUsername.Text, txtPassword.Text))//if admin,check in admin schema
                {
                    Session["username"] = txtUsername.Text;
                    Response.Redirect("AdminHome.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Invalid Username or password');</script>");
                }
             }
                
            if (userType.Equals("Student"))
            {
                if (ValidLogin.IsUser(txtUsername.Text, txtPassword.Text))//if student,check in student schema
                {
                    Session["username"] = txtUsername.Text;
                    Response.Redirect("StudentHome.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Invalid Username or password');</script>");
                }
            }

        }
    }
}