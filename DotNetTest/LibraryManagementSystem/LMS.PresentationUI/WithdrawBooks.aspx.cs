using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LMS.DataAccess;
namespace LMS.PresentationUI
{
    public partial class WithdrawBooks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
         protected void BtnWithDraw_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtBookID.Text);
            string issuer = txtUserName.Text;
            IssueDetailsOperations.WithDrawBook(id, issuer);

        }
       
    }
}