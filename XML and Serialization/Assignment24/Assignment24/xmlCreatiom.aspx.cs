using System;
using System.Xml;
namespace Assignment24
{
    public partial class xmlCreatiom : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string path = Server.MapPath("~/Training.xml");
            XmlTextWriter textWriter =new XmlTextWriter(path,null);
              textWriter.WriteStartDocument();
            textWriter.WriteStartElement("iCalibrator");
            textWriter.WriteStartElement("Training");
            textWriter.WriteAttributeString("day", "1");
            textWriter.WriteStartElement("Chapter");
            textWriter.WriteString("XML-1");
            textWriter.WriteEndElement();
            textWriter.WriteStartElement("Chapter");
            textWriter.WriteString("XML-2");
            textWriter.WriteEndElement();
            textWriter.WriteEndElement();
            textWriter.WriteEndElement();
            textWriter.WriteEndDocument();
            textWriter.Close();
       }
        }
    }