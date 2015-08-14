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
        /// <summary>
        /// method to view all the books in a gridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            gvBooks.DataSource = BooksOperations.GetBook();  
            gvBooks.DataBind();
        }
    }
}