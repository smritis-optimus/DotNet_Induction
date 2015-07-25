using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using System.Data;
namespace Ado.netAssignment
{
    public partial class All_Students : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetStream();
                LoadData();
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
            GridView1.DataSource = null;
            GridView1.DataBind();
            GridView1.DataSource = new Student().GetAllStudents(Convert.ToInt32(dlStream.SelectedValue));
            GridView1.DataBind();
        }

        private void LoadData()
        {
            GridView1.DataSource = new Student().GetAllStudents();
            GridView1.DataBind();
        }

        protected void GridView1_Sorting(object sender, GridViewSortEventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Age", typeof(int));
            dt.Columns.Add("Stream", typeof(string));
            dt.Columns.Add("State", typeof(string));
            foreach (GridViewRow row in GridView1.Rows)
            {
                int Id = int.Parse(row.Cells[0].Text);
                string Name = row.Cells[1].Text;
                int Age = int.Parse(row.Cells[2].Text);
                string Stream = row.Cells[3].Text;
                string State = row.Cells[4].Text;
                dt.Rows.Add(Id, Name, Age, Stream, State);
            }
            if (dt != null)
            {
                dt.DefaultView.Sort = e.SortExpression + " " + "ASC";
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }

        }


       
        }
    }

