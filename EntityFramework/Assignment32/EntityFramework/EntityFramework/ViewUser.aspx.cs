using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace EntityFramework
{
    public partial class ViewUser : System.Web.UI.Page
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                BindGridView();
            }

        }
        protected void BindGridView()
        {
            var test = from i in db.UserTables
                       select i;
            if (test != null)
            {
                GridView1.DataSource = test;
                GridView1.DataBind();
            }
        }
 
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            BindGridView();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

            int id = Convert.ToInt32((GridView1.Rows[e.RowIndex].FindControl("Label1") as Label).Text);
           UserTable tb1 = (from UserTable in db.UserTables
                                   where UserTable.Id == id
                                   select UserTable).First();

            // Delete row from database table
            db.UserTables.DeleteOnSubmit(tb1);
            db.SubmitChanges();
            GridView1.EditIndex = -1;
            BindGridView();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            // Find student id for update the row
            int id = Convert.ToInt32((GridView1.Rows[e.RowIndex].FindControl("Label1") as Label).Text);

             //Find new updated values for TexBox
            TextBox fname = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txt_fname");
            TextBox lname = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txt_lname");
            TextBox role = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txt_role");
            TextBox age = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txt_age");
            TextBox address = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txt_address");
            TextBox phone = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txt_phone");
            // Select specific row from database table
            UserTable tb1 = (from UserTable in db.UserTables
                             where UserTable.Id == id
                             select UserTable).First();
            tb1.FirstName = fname.Text;
            tb1.LastName = lname.Text;
            tb1.Role=role.Text;
            tb1.Age = Convert.ToInt32(age.Text);
            tb1.Address = address.Text;
            tb1.Phone = phone.Text;


            // Update changes in database table
            db.SubmitChanges();

            GridView1.EditIndex = -1;
            BindGridView();
        }

        // Cancel row edit operation
        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            BindGridView();
           
        }

      

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            TextBox Id = (TextBox)GridView1.FooterRow.FindControl("Id");
            TextBox fname = (TextBox)GridView1.FooterRow.FindControl("FirstName");
            TextBox lname = (TextBox)GridView1.FooterRow.FindControl("LastName");
            TextBox role = (TextBox)GridView1.FooterRow.FindControl("Role");
            TextBox age = (TextBox)GridView1.FooterRow.FindControl("Age");
            TextBox address = (TextBox)GridView1.FooterRow.FindControl("Address");
            TextBox phone = (TextBox)GridView1.FooterRow.FindControl("Phone");
            UserTable tb2 = new UserTable();
            tb2.Id = Convert.ToInt32(Id.Text);
            tb2.FirstName = fname.Text;
            tb2.LastName = lname.Text;
            tb2.Role = role.Text;
            tb2.Age = Convert.ToInt32(age.Text);
            tb2.Address = address.Text;
            tb2.Phone = phone.Text;

            // Insert into database
            db.UserTables.InsertOnSubmit(tb2);
            db.SubmitChanges();
            // Refresh Gridview for reflecting new row
            BindGridView();
        }

        

     
    }
}
