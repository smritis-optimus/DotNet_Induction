using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntityFramework
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (username.Text.Equals("admin"))
            {
                Session["username"] = username.Text;
                Response.Redirect("AdminHome.aspx");

            }
            else
                  {
                      Session["username"] = username.Text;
                    Response.Redirect("Upload.aspx");

            }
        }
    }
}