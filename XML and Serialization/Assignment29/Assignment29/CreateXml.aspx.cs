using System;
using System.Xml;
namespace Assignment29
{
    public partial class CreateXml : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string path = Server.MapPath("~/Students.xml");
            XmlTextWriter textWriter = new XmlTextWriter(path, null);
            textWriter.WriteStartDocument();
            textWriter.WriteStartElement("Students");
            textWriter.WriteStartElement("Student");
            textWriter.WriteAttributeString("name", "Preeti");
            textWriter.WriteAttributeString("age", "22");
            textWriter.WriteStartElement("Stream");
            textWriter.WriteString("PCM");
            textWriter.WriteEndElement();
            textWriter.WriteStartElement("Address");
            textWriter.WriteStartElement("City");
            textWriter.WriteString("Delhi");
            textWriter.WriteEndElement();
            textWriter.WriteStartElement("Country");
            textWriter.WriteString("India");
            textWriter.WriteEndElement();
            textWriter.WriteEndElement();
            textWriter.WriteEndElement();
            textWriter.WriteStartElement("Student");
            textWriter.WriteAttributeString("name", "Priya");
            textWriter.WriteAttributeString("age", "24");
            textWriter.WriteStartElement("Stream");
            textWriter.WriteString("PCB");
            textWriter.WriteEndElement();
            textWriter.WriteStartElement("Address");
            textWriter.WriteStartElement("City");
            textWriter.WriteString("Mumbai");
            textWriter.WriteEndElement();
            textWriter.WriteStartElement("Country");
            textWriter.WriteString("India");
            textWriter.WriteEndElement();
            textWriter.WriteEndElement();
            textWriter.WriteEndElement();
            textWriter.WriteStartElement("Student");
            textWriter.WriteAttributeString("name", "Anjali");
            textWriter.WriteAttributeString("age", "25");
            textWriter.WriteStartElement("Stream");
            textWriter.WriteString("Commerce");
            textWriter.WriteEndElement();
            textWriter.WriteStartElement("Address");
            textWriter.WriteStartElement("City");
            textWriter.WriteString("Delhi");
            textWriter.WriteEndElement();
            textWriter.WriteStartElement("Country");
            textWriter.WriteString("India");
            textWriter.WriteEndElement();
            textWriter.WriteEndElement();
            textWriter.WriteEndElement();
            textWriter.WriteStartElement("Student");
            textWriter.WriteAttributeString("name", "Mohan");
            textWriter.WriteAttributeString("age", "24");
            textWriter.WriteStartElement("Stream");
            textWriter.WriteString("PCM");
            textWriter.WriteEndElement();
            textWriter.WriteStartElement("Address");
            textWriter.WriteStartElement("City");
            textWriter.WriteString("Chennai");
            textWriter.WriteEndElement();
            textWriter.WriteStartElement("Country");
            textWriter.WriteString("India");
            textWriter.WriteEndElement();
            textWriter.WriteEndElement();
            textWriter.WriteEndElement();
            textWriter.WriteStartElement("Student");
            textWriter.WriteAttributeString("name", "Shivam");
            textWriter.WriteAttributeString("age", "22");
            textWriter.WriteStartElement("Stream");
            textWriter.WriteString("PCM");
            textWriter.WriteEndElement();
            textWriter.WriteStartElement("Address");
            textWriter.WriteStartElement("City");
            textWriter.WriteString("Delhi");
            textWriter.WriteEndElement();
            textWriter.WriteStartElement("Country");
            textWriter.WriteString("India");
            textWriter.WriteEndElement();
            textWriter.WriteEndElement();
            textWriter.WriteEndElement();
            textWriter.WriteEndElement();
            textWriter.WriteEndDocument();
            textWriter.Close();

        }
    }
}