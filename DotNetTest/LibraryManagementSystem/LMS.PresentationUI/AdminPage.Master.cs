using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LMS.PresentationUI
{
    public partial class AdminPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
                Response.Redirect("Login.aspx");
            lblUserName.Text = "WELCOME : " + Session["username"];

        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("Login.aspx"); 
        }

    }
}