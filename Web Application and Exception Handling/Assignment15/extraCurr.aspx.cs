﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class extraCurr : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        lb1.Text = "WELCOME : " + Session["username"];
    }
}