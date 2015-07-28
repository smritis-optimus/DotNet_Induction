using System;
using System.Web;
using System.Xml;
using System.Xml.XPath;
using System.Text;
namespace Assignment24
{
    public partial class ReadXml : System.Web.UI.Page
    {
        string path = HttpContext.Current.Server.MapPath("~/Training.xml");
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnAddNode_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlNode root = doc.DocumentElement;
            XmlElement element = doc.CreateElement("Assignment");
            element.SetAttribute("Submitted", "y");
            XmlElement number = doc.CreateElement("number");
            number.InnerText = "1";
            element.AppendChild(number);
            root.AppendChild(element);
            doc.Save(path);
        }

        protected void btnFirstChild_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlNode root = doc.DocumentElement;
            XmlNode node = root.FirstChild;
            txtFirstChild.Text = node.ToString();
        }

        protected void btnInsertBefore_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlElement root = doc.DocumentElement;
            XmlNodeList nodes = root.ChildNodes;
            XmlElement element = doc.CreateElement("Testing");
            foreach (XmlNode node in nodes)
            {
                if (node.Name.CompareTo("Training") == 0)
                {
                    root.InsertBefore(element, node);
                }
            }
            doc.Save(path);

        }

        protected void btnRemoveNode_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlElement root = doc.DocumentElement;
            XmlNodeList nodes = root.ChildNodes;
            foreach (XmlNode node in nodes)
            {
                if (node.Name.CompareTo("Assignment") == 0)
                {
                    root.RemoveChild(node);
                }
            }
            doc.Save(path);
        }

        protected void btnChildNode_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XPathNavigator navigator = doc.CreateNavigator();
            navigator.MoveToRoot();
            navigator.MoveToFirstChild();
            StringBuilder childNodes = new StringBuilder();
            if (navigator.HasChildren)
            {
                navigator.MoveToFirstChild();
                do
                {
                    childNodes.Append(navigator.Name + "--");
                } while (navigator.MoveToNext());
            }
            txtChildNodes.Text = childNodes.ToString();

        }

        protected void btnTotalNode_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XPathNavigator navigator = doc.CreateNavigator();
            navigator.MoveToRoot();
            navigator.MoveToFirstChild();
            StringBuilder childNodes = new StringBuilder();
            int count = 0;
            if (navigator.HasChildren)
            {
                navigator.MoveToFirstChild();
                do
                {
                    count++;
                } while (navigator.MoveToNext());
            }
           txtCountNodes.Text = Convert.ToString(count);
        }

        protected void btnReplaceChild_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XPathNavigator navigator = doc.CreateNavigator();
            navigator.MoveToRoot();
            navigator.MoveToFirstChild();
            if (navigator.HasChildren)
            {
                navigator.MoveToFirstChild();
                do
                {
                    if (navigator.Name.CompareTo("Testing") == 0)
                    {
                        navigator.ReplaceSelf("<Testing_Over />");
                    }
                } while (navigator.MoveToNext());
            }
            doc.Save(path);
        }

    }
}