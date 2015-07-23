using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntityFramework1
{
    public partial class DeleteUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DeletUser_Click(object sender, EventArgs e)
        {
            using (SampleUserEntities DeleteUser = new SampleUserEntities())
            {
                int i = Convert.ToInt32(Id.Text);
                var query = (from UserTable in DeleteUser.UserTables
                             where UserTable.Id == i
                             select UserTable).FirstOrDefault();
                DeleteUser.UserTables.Remove(query);

                DeleteUser.SaveChanges();
                Response.Redirect("AdminHome.aspx");
            }
        }
    }
}