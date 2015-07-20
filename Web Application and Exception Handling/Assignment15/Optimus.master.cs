using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Optimus : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
        lbl1.Text = "WELCOME : " + Session["username"];
    }
    protected void logout_Click(object sender, EventArgs e)
    {
        Session.Clear();
        
        Response.Redirect("Login.aspx"); 
    }
}
