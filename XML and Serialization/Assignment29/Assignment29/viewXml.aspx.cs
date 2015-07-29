using System;
using System.Xml;
using System.Web;
using System.Xml.Xsl;
using System.Xml.XPath;
namespace Assignment29
{
    public partial class viewXml : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string filename = Server.MapPath(@"~/Students.xml");
            string stylesheet = Server.MapPath(@"~/Student.xslt");
            XmlDocument document = new XmlDocument();
            //load the xml file
            document.Load(Server.MapPath(@"~\Students.xml"));
            XmlNode root = document.DocumentElement;
            foreach (XmlNode node in root.ChildNodes)
            {
                //if stream is PCM add a new node of college
                if (node.ChildNodes.Item(0).InnerText.Equals("PCM"))
                {
                    XmlElement newelement = document.CreateElement("College");
                    newelement.InnerText = "Engineering";
                    node.AppendChild(newelement);
                }
            }
            document.Save(Server.MapPath(@"~\Students.xml"));
            //create an object of XPathDocument
            XPathDocument myXPathDoc = new XPathDocument(filename);
            //Load the transformation from the stylesheet
            XslCompiledTransform myXslTrans = new XslCompiledTransform();
            myXslTrans.Load(stylesheet);
            //load it into result.html to show the result
            XmlTextWriter myWriter = new XmlTextWriter(Server.MapPath(@"~/result.html"), null);
            myXslTrans.Transform(myXPathDoc, null, myWriter);
            Response.Redirect("result.html");
        }
    }
}