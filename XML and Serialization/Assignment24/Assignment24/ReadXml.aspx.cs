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
        //<summary>
        //method for adding a node Assignment
        //</summary>
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
        //<summary>
        //method for displaying the first child
        //</summary>
        protected void btnFirstChild_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlNode root = doc.DocumentElement;
            txtFirstChild.Text = root.FirstChild.Name;
        }
        //<summary>
        //method for inserting a node Testing before Training
        //</summary>
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
        //<summary>
        //method for removing Assignment node
        //</summary>
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
        //<summary>
        //method for displaying the child nodes
        //</summary>
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
        //<summary>
        //method for counting all the nodes
        //</summary>
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
        //<summary>
        //method for replacing Testing node with testing over
        //</summary>
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