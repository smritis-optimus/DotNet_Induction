using System;

namespace Assignment26
{
    public partial class ReadFromXML : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
            if (fileUpload.HasFile)
            {
                fileUpload.SaveAs(Server.MapPath("~/") + fileUpload.FileName);
                if (UtilityClass.LoadStudents(Server.MapPath(fileUpload.FileName)))
                    lblMessage.Text="Data read from xml file and uploaded in database";
                else
                    lblMessage.Text="Some error occured.";
            }
                else
                    lblMessage.Text = "you have not spcefied a file";
            }
            catch (Exception ex)
            {
                Response.Write("Error occured :"+ ex.Message);
            }
        }
    }
}