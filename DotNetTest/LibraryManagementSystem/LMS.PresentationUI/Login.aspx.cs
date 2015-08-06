using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LMS.DataAccess;
namespace LMS.PresentationUI
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            if (ValidLogin.IsAdmin(txtUsername.Text, txtPassword.Text))
            {
                Session["username"] = txtUsername.Text;
                Response.Redirect("AdminHome.aspx");
            }
            else
            {
                if (ValidLogin.IsUser(txtUsername.Text, txtPassword.Text))
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