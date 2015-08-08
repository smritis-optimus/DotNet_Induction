using System;
using LMS.DataAccess;
namespace LMS.PresentationUI
{
    public partial class IssueHistoryOfAllStudents : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                BindGridview();
        }
        /// <summary>
        /// method to bind the list of all studens with their respective issue history
        /// </summary>
        protected void BindGridview()
        {
            gvStudentDetails.DataSource = StudentsOperations.GetStudentsWithIssuingHistory();
            gvStudentDetails.DataBind();
        }
    }
}