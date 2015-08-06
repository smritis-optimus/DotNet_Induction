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
    public partial class ViewBooks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            gvBooks.DataSource = BooksOperations.ViewBook();  
            gvBooks.DataBind();
        }
    }
}