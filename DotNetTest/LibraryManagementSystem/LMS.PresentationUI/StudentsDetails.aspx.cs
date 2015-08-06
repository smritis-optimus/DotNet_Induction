using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LMS.DataAccess;
namespace LMS.PresentationUI
{
    public partial class StudentsDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                BindGridview();
        }
        protected void BindGridview()
        {
            gvStudentDetails.DataSource = StudentsOperations.ViewStudent();
            gvStudentDetails.DataBind();
        }
        protected void GvStudentRowEditing(object sender, GridViewEditEventArgs e)
        {
            gvStudentDetails.EditIndex = e.NewEditIndex;
            BindGridview();
        }
        protected void GvStudentRowCancelingEdit(object sender, GridViewEditEventArgs e)
        {
        }

    }
}