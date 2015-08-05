using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWebApp
{
    public partial class WebFormToTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            Response.Write("<script>alert(Percentage entered : '" + student.GetPercentage(txtPercentage.Text) + "');</script>"); ;
        }
    }
}