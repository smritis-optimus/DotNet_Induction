using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace Ado.netAssignment
{
    public partial class EditStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
              if (!IsPostBack)
            {
                GetStream();
               GetState();
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
                item.Value = pair.Value.ToString();
                item.Text = pair.Value.ToString();
                dlStream.Items.Add(item);
            }
        }


        private void GetState()
        {
            Dictionary<int, string> dictionary;
            ListItem item;
            if (Cache["StateData"] == null)
            {
                dictionary = UtilityFunctions.GetAllStates();
                Cache["StateData"] = dictionary;
            }
            else
            {
                dictionary = (Dictionary<int, string>)Cache["StateData"];
            }
            dictionary = UtilityFunctions.GetAllStates();
            item = new ListItem();
            item.Value = null;
            item.Text = "Select State";
            dlState.Items.Add(item);
            foreach (KeyValuePair<int, string> pair in dictionary)
            {
                item = new ListItem();
                item.Value = pair.Value.ToString();
                item.Text = pair.Value.ToString();
                dlState.Items.Add(item);
            }
        }


        protected void btnSearch_Click(object sender, EventArgs e)
        {
            Student student = new Student().GetStudent(Convert.ToInt32(txtId.Text));
            if (student != null)
            {
                txtName.Enabled = true;
                txtAge.Enabled = true;
                dlState.Enabled = true;
                dlStream.Enabled = true;
                btnUpdate.Enabled = true;
                txtId.Enabled = false;
                txtName.Text = student.Name;
                txtAge.Text = student.Age.ToString();
            }
            else
            {
                txtName.Enabled = false;
                txtAge.Enabled = false;
                dlState.Enabled = false;
                dlStream.Enabled = false;
                btnUpdate.Enabled = false;
                txtId.Enabled = true;
                Response.Write("<script>alert('No Student was found!!')</script>");
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Id = Convert.ToInt32(txtId.Text);
            student.Name = txtName.Text;
            student.Age = Convert.ToInt32(txtAge.Text);
            student.Stream = dlStream.SelectedValue;
            student.State = dlState.SelectedValue;
            if (!student.UpdateStudents())
            {
                Response.Write("<script>alert('Record Updated Successfully.')</script>");
                txtId.Text = "";
                txtName.Text = "";
                txtAge.Text = "";
                dlStream.Items.Remove(dlStream.SelectedItem);
                dlState.Items.Remove(dlState.SelectedItem);
            }
            else
                Response.Write("<script>alert('Failure')</script>");
        }
        }
    }
