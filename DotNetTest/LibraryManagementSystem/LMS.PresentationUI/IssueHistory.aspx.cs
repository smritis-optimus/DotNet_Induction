using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LMS.DataAccess;
namespace LMS.PresentationUI
{
    public partial class IssueHistory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string cuurentUser = Session["username"].ToString();
            gvHistory.DataSource = StudentsOperations.ViewHistory(cuurentUser);
            gvHistory.DataBind();
        }
    }
}