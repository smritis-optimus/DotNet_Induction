using System;
using LMS.DataAccess;
namespace LMS.PresentationUI
{
    public partial class IssueHistory : System.Web.UI.Page
    {
        /// <summary>
        /// method to view issue history of current user in gridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            string currentUser = Session["username"].ToString();
            gvHistory.DataSource = StudentsOperations.GetHistory(currentUser);
            gvHistory.DataBind();
        }
    }
}