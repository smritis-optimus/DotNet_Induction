using System;
using LMS.DataAccess;
namespace LMS.PresentationUI
{
    public partial class IssueBooks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        /// <summary>
        /// method to take the selected bookid and username from admin and 
        /// send it to function that adds an issue
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnIssue_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtBookID.Text);
            string issuer = txtUserName.Text;
            IssueDetailsOperations.IssueBook(id, issuer);
        }
    }
}