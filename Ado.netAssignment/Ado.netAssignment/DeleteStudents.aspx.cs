using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ado.netAssignment
{
    public partial class DeleteStudents : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetStream();
             
            }
        }
        private void GetStream()
        {
            Dictionary<int, string> dictionary;
            ListItem item;
            if (Cache["StreamData"] == null)
            {
                dictionary = UtilityFunctions.GetAllStreams();
                Cache["StreamData"] = dictionary;
            }
            else
            {
                dictionary = (Dictionary<int, string>)Cache["StreamData"];
            }
            item = new ListItem();
            item.Value = null;
            item.Text = "Select Stream";
            dlStream.Items.Add(item);
            foreach (KeyValuePair<int, string> pair in dictionary)
            {
                item = new ListItem();
                item.Value = pair.Key.ToString();
                item.Text = pair.Value.ToString();
                dlStream.Items.Add(item);
            }
        }

        protected void dlStream_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            List<Student> students = new Student().GetAllStudents(Convert.ToInt32(dlStream.SelectedValue));
            ListItem item;
           
            foreach (Student s in students)
            {
                item = new ListItem();
                item.Value = s.Id.ToString();
                item.Text = s.Name;
                SelectedStreamList1.Items.Add(item);
            }
          
        }
    

        protected void btnLeft_Click(object sender, EventArgs e)
        {
            while (SelectedStreamList2.Items.Count != 0)
            {
                for (int i = 0; i < SelectedStreamList2.Items.Count; i++)
                {
                    SelectedStreamList1.Items.Add(SelectedStreamList2.Items[i]);
                    SelectedStreamList2.Items.Remove(SelectedStreamList2.Items[i]);
                }
            }
        }

        protected void btnRight_Click(object sender, EventArgs e)
        {
            while (SelectedStreamList1.Items.Count != 0)
            {
                for (int i = 0; i < SelectedStreamList1.Items.Count; i++)
                {
                    SelectedStreamList2.Items.Add(SelectedStreamList1.Items[i]);
                    SelectedStreamList1.Items.Remove(SelectedStreamList1.Items[i]);
                }
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            String selectedItem = "";
            if (SelectedStreamList1.Items.Count > 0)
        {
            for (int i = 0; i < SelectedStreamList1.Items.Count; i++)
            {
                if (SelectedStreamList1.Items[i].Selected)
                {
                    selectedItem = selectedItem + SelectedStreamList1.Items[i].Value + ",";
                   
            }
        }
            Response.Write("<script>confirm('Do you want to delete?"+selectedItem+"')</script>");
 
                 
        }
             if (new Student().DeleteStudents(selectedItem))
                 Response.Write("<script>Deleted Successfully</script>");
             else
                 Response.Write("<script>Deletion Failed</script>");

    }
}
}