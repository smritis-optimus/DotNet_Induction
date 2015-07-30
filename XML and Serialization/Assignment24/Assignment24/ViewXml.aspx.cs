using System;
using System.Web;
using System.Xml;
namespace Assignment24
{
    public partial class ViewXml : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String Temp;
            XmlDocument doc=new XmlDocument();
            doc.Load(Server.MapPath("~/Training.xml"));
            Temp = doc.InnerXml;
            Temp = Temp.Replace("<", "<br />&lt;");
            Temp = Temp.Replace(">", "&gt;<br />");
            Response.Write(Temp);      
        }
    }
}