using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DesignPatternMVC.View
{
    /// <summary>
    /// view of student
    /// </summary>
    public partial class StudentView : System.Web.UI.UserControl
    {
        public string Name { get; set; }
        public int Rollno { get; set; }
        public int Age { get; set; }
        public string Branch { get; set; }
        private Controller.StudentController Control;
        //create a new student model
        private Model.StudentModel Model = new Model.StudentModel("Ashish", 2, 20, "Science");
        //craete a view on page load
        protected void Page_Load(object sender, EventArgs e)
        {
            Control = new Controller.StudentController(Model, this);
            Model.AddObserver(this);
            Control.InitializedComponent(IsPostBack);
        }
        /// <summary>
        /// method to take updated values from textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Name = txtName.Text.ToString();
            Rollno = Convert.ToInt32(txtRollno.Text.ToString());
            Age = Convert.ToInt32(txtAge.Text.ToString());
            Branch = txtBranch.Text.ToString();
            Control.RequestUpdate(this);
        }
        /// <summary>
        /// method to call UpdateInterFace
        /// </summary>
        /// <param name="paramModel"></param>
        public void Update(Model.StudentModel paramModel)
        {
            UpdateInterface(paramModel);
        }
        /// <summary>
        /// method to update the inteface
        /// </summary>
        /// <param name="auto"></param>
        public void UpdateInterface(Model.StudentModel auto)
        {
            if(Name!=auto.Name)
            lblName.Text = Name;
            if(Rollno!=auto.Rollno)
            lblRollno.Text = Rollno.ToString();
            if(Age!=auto.Age)
            lblAge.Text = Age.ToString();
            if(Branch!=auto.Branch)
            lblBranch.Text = Branch;
        }
        /// <summary>
        /// method to intialize the view on page load
        /// </summary>
        /// <param name="paramModel"></param>
        public void InitializedView(Model.StudentModel paramModel)
        {
            lblName.Text = paramModel.Name.ToString();
            lblRollno.Text = paramModel.Rollno.ToString();
            lblAge.Text = paramModel.Age.ToString();
            lblBranch.Text = paramModel.Branch.ToString();
        }
        /// <summary>
        /// method to add a new Student
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Name = txtName.Text.ToString();
            Rollno = Convert.ToInt32(txtRollno.Text.ToString());
            Age = Convert.ToInt32(txtAge.Text.ToString());
            Branch = txtBranch.Text.ToString();
            Model.AddObserver(this);
        }
        /// <summary>
        /// method to remove a student
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            Name = lblName.Text.ToString();
            Rollno = Convert.ToInt32(lblRollno.Text.ToString());
            Age = Convert.ToInt32(lblAge.Text.ToString());
            Branch = lblBranch.Text.ToString();
            Model.AddObserver(this);
            Model.RemoveObserver(this);
        }
    }
}