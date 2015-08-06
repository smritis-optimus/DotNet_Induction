using System;
using System.Web.UI.WebControls;
using LMS.DataAccess;
namespace LMS.PresentationUI
{
    public partial class BooksDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                BindGridview();
        }
        protected void BindGridview()
        {
            gvBooks.DataSource = BooksOperations.ViewBook();
            gvBooks.DataBind();
        }
        protected void GvBooksRowEditing(object sender, GridViewEditEventArgs e)
        {
           gvBooks.EditIndex = e.NewEditIndex;
           BindGridview();
        }
        protected void GvBooksRowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32((gvBooks.Rows[e.RowIndex].FindControl("lblBindBookID") as Label).Text);
            BooksOperations.DeleteBook(id);
            BindGridview();
        }
        protected void GvBooksRowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id = Convert.ToInt32((gvBooks.Rows[e.RowIndex].FindControl("lblBookID") as Label).Text);
            TextBox Name = (TextBox)gvBooks.Rows[e.RowIndex].FindControl("txtName");
            TextBox Author = (TextBox)gvBooks.Rows[e.RowIndex].FindControl("txtAuthor");
            TextBox Category = (TextBox)gvBooks.Rows[e.RowIndex].FindControl("txtCategory");
            TextBox Quantity = (TextBox)gvBooks.Rows[e.RowIndex].FindControl("txtQuantity");
            BooksOperations.UpdateBook(id,Name.Text,Author.Text,Category.Text,Convert.ToInt32(Quantity.Text));
            BindGridview();
        }
        protected void GvBooksRowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvBooks.EditIndex = -1;
            BindGridview();
        }
        protected void GvBooksSelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox BookId = (TextBox)gvBooks.FooterRow.FindControl("txtAddBookID");
            TextBox Name = (TextBox)gvBooks.FooterRow.FindControl("txtAddName");
            TextBox Author = (TextBox)gvBooks.FooterRow.FindControl("txtAddAuthor");
            TextBox Category = (TextBox)gvBooks.FooterRow.FindControl("txtAddCategory");
            TextBox Quantity = (TextBox)gvBooks.FooterRow.FindControl("txtAddQuantity");
            BooksOperations.AddBook(Convert.ToInt32(BookId.Text), Name.Text, Author.Text, Category.Text, Convert.ToInt32(Quantity.Text));
            BindGridview();
        }
    }
}