﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntityFramework
{
    public partial class Admin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             //if(Session["username"]==null)
                //Response.Redirect("Login.aspx");
            user.Text = "WELCOME : " + Session["username"];
        }
        protected void logout_Click(object sender, EventArgs e)
        {
            Session.Clear();

            Response.Redirect("Home.aspx"); 
        }
    }
}