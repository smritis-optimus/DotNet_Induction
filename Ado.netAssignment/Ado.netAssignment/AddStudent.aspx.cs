using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace Ado.netAssignment
{
    public partial class AddStudent : System.Web.UI.Page
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
                    item.Value = pair.Key.ToString();
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
                item = new ListItem();
                item.Value = null;
                item.Text = "Select State";
                dlState.Items.Add(item);
                foreach (KeyValuePair<int, string> pair in dictionary)
                {
                    item = new ListItem();
                    item.Value = pair.Key.ToString();
                    item.Text = pair.Value.ToString();
                    dlState.Items.Add(item);
                }
            }
    
    protected void btnAdd_Click(object sender, EventArgs e)
        {
            Student s1 = new Student();
            s1.Id = Convert.ToInt32(txtId.Text);
            s1.Name = txtName.Text;
            s1.Age = Convert.ToInt32(txtAge.Text);
            s1.State = dlState.SelectedValue;
            s1.Stream = dlStream.SelectedValue;
            if (s1.AddStudent())
            {
                Response.Write("<script>alert('Successful')</script>");
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
