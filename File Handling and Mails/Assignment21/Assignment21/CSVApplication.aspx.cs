using System;

namespace Assignment21
{
    public partial class CSVApplication : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSaveToDB_Click(object sender, EventArgs e)
        {
            try
            {
                if (fileUploadCSV.HasFiles)
                {
                    //save the file in a specified folder
                   fileUploadCSV.SaveAs(Server.MapPath("~/")+fileUploadCSV.FileName);
                    //calling the function to read all contents from csv file
                    if (UtilityClass.LoadFromCSV(Server.MapPath(fileUploadCSV.FileName)))
                        lblMessage.Text="All data read from csv file and inserted";
                    else
                        lblMessage.Text="Some error occured";
                }

                else
                {
                    lblMessage.Text = "you have not spcefied a file";
                }
            }
            catch (Exception ex)
            {
                Response.Write("Error occured :"+ ex.Message);
            }
        }
    }
}