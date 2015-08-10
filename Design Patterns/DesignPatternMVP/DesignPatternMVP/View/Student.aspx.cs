using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DesignPatternMVP.Presenter;
namespace DesignPatternMVP.View
{
    public partial class Student : System.Web.UI.Page,IStudentView
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        /// <summary>
        /// loading the values from textbox to presenter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnAddStudent_Click(object sender, EventArgs e)
        {
            LoadView();
        }

        public string Name
        {
            get
            {
                return txtName.Text;
            }
            set
            {
                txtName.Text = value;
            }
        }

        public int Age
        {
            get
            {
                return Convert.ToInt32(txtAge.Text);
            }
            set
            {
                txtAge.Text = value.ToString();
            }
        }

        public int Rollno
        {
            get
            {
                return Convert.ToInt32(txtRollNo.Text);
            }
            set
            {
                txtRollNo.Text = value.ToString();
            }
        }

        public string Branch
        {
            get
            {
                return txtBranch.Text;
            }
            set
            {
                txtBranch.Text = value;
            }
        }
        /// <summary>
        /// load the added student and show it on gridview
        /// </summary>
        public void LoadView()
        {
            StudentPresenter presenter = new StudentPresenter(this);        
            presenter.LoadStudentUI();
            lblMessage.Text = "Added!";
            gvStudents.DataSource = presenter.GetStudents();
            gvStudents.DataBind();
        }
    }
}