using System;
using System.Web;

namespace Assignment24
{
    public partial class ViewXml : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Clear();
            Response.Buffer = true;
            Response.Charset = "";
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.ContentType = "application/xml";
            Response.WriteFile(Server.MapPath("~/Training.xml"));
            Response.Flush();
            Response.End();

            
        }
    }
}