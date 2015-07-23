using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntityFramework
{
    public partial class Upload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Upload_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
                try
                {
                    FileUpload1.SaveAs("C:\\Uploads\\" +
                         FileUpload1.FileName);
                    UploadFile.Text = "File uploaded!!! ";
                }
                catch (Exception ex)
                {
                    UploadFile.Text = "ERROR: " + ex.Message.ToString();
                }
            else
            {
                UploadFile.Text = "You have not specified a file.";
            }
        }
    }
}