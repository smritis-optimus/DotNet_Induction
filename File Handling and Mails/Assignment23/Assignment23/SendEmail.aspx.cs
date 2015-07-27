using System;
using System.IO;
using System.Net.Mail;


namespace Assignment23
{
    public partial class SendEmail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            string deletedFile="";
            FileInfo fileInfoSize;
            byte sizeOfFile;
            if (Directory.Exists(txtFolder.Text))
            {
                string[] fileIsnDirectory = Directory.GetFiles(txtFolder.Text);
                foreach(string fileName in fileIsnDirectory)
                {
                    fileInfoSize = new FileInfo(fileName);
                    sizeOfFile = Convert.ToByte(fileInfoSize.Length);
                    if (sizeOfFile > 100)
                    {
                        deletedFile += fileName;
                        File.Delete(fileName);
                       
                    }
                    else
                    {
                        using (StreamWriter sw = File.AppendText(fileName))
                        {
                            sw.WriteLine("Size less than 100 bytes");
                        }
                    }

                }
                SendMail(deletedFile);

            }
        }
        protected void SendMail(string msgBody)
        {
            MailMessage mail = new MailMessage("smriti.singh@optimusinfo.com", "smriti.singh@optimusinfo.com");
            mail.Subject = "Deleted Files";
            mail.Body = msgBody;
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.Credentials = new System.Net.NetworkCredential("smriti.singh@optimusinfo.com", "password");
            client.EnableSsl = true;
            client.Send(mail);
            Response.Write("<script>alert('Mail Sent')</script>");
        }
    }
}