using System;
using System.Xml;
using System.Web;
namespace Assignment29
{
    public partial class viewXml : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            XmlDocument document = new XmlDocument();
            document.Load(Server.MapPath(@"~\Students.xml"));
            XmlNode root = document.DocumentElement;
            foreach (XmlNode node in root.ChildNodes)
            {
                if (node.ChildNodes.Item(0).InnerText.Equals("PCM"))
                {
                    XmlElement newelement = document.CreateElement("College");
                    newelement.InnerText = "Engineering";
                    node.AppendChild(newelement);
                }
            }
            document.Save(Server.MapPath(@"~\Students.xml"));
            Response.Clear();
            Response.Buffer = true;
            Response.Charset = "";
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.ContentType = "application/xml";
            Response.WriteFile(Server.MapPath(@"~/Students.xml"));
            Response.Flush();
            Response.End();
            
        }
        }
    }