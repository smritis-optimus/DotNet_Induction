using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntityFramework
{
    public partial class UpdateUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            //using (SampleUserEntities UpdateUser = new SampleUserEntities())
            //{
            //    int i = Convert.ToInt32(Id.Text);
            //    var query = (from UserTable in UpdateUser.UserTable
            //                 where UserTable.Id == i
            //                 select UserTable).FirstOrDefault();
            //    FirstName.Text = query.FirstName;
            //    LastName.Text = query.LastName;
            //    Role.Text = query.Role;
            //    Age.Text = query.Age.ToString();
            //    Address.Text = query.Address;
            //    Phone.Text = query.Phone;

            //}
        }

        protected void UpdateUser_Click(object sender, EventArgs e)
        {
            //using (SampleUserEntities UpdateUser = new SampleUserEntities())
            //{
            //    int i = Convert.ToInt32(Id.Text);
            //    var query = (from UserTable in UpdateUser.UserTable
            //                 where UserTable.Id == i
            //                 select UserTable).FirstOrDefault();


            //    query.FirstName = FirstName.Text;
            //    query.LastName = LastName.Text;
            //    query.Role = Role.Text;
            //    query.Age = int.Parse(Age.Text);
            //    query.Address = Address.Text;
            //    query.Phone = Phone.Text;
            //    SampleUserEntities db = new SampleUserEntities();
            //    UpdateUser.SaveChanges();
                
            //}
            Response.Redirect("AdminHome.aspx");   
        }
    }
}