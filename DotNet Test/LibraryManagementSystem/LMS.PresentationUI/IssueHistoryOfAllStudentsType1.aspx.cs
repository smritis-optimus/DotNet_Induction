using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LMS.DataAccess;
using System.Data;
namespace LMS.PresentationUI
{
    public partial class IssueHistoryOfAllStudentsType1 : System.Web.UI.Page
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
            GridView2.DataSource = StudentsOperations.GetStudentsWithIssuingHistory();
            GridView2.DataBind();
            GridView1.DataSource = StudentsOperations.GetIssuedBooks();
            GridView1.DataBind();
        }
    }
}