using System;
using System.Collections.Generic;
using System.Xml.Linq;
namespace Assignment25
{
    public partial class XmlViewData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        public void DdlStudentsSSelectedIndexChanged(Object sender, EventArgs e)
        {
            //select an option to view the student list  from dropdown menu
            int choiceOfStudentList = Convert.ToInt32(DdlStudents.SelectedItem.Value);
            string pathofXml = "C:\\student.xml";
            XDocument xDoc = XDocument.Load(pathofXml);
            //creating a list of students
            List<Student> students = new List<Student>();
            Student newStudent;
            //when no choice is selected show an alert
            if(choiceOfStudentList==0)
                Response.Write("<script>alert('Select a category')</script>");
            //when MCA choice is selected
            if (choiceOfStudentList == 1)
            {
                string branch = "";
                foreach (var record in xDoc.Descendants("Student"))
                {
                    newStudent = new Student();
                    //check if branch is MCA,then add those students into list
                    branch = record.Element("Branch").Value;
                    if (branch.Equals("MCA"))
                    {
                        try
                        {
                            newStudent.RollNo = Convert.ToInt32(record.Element("RollNo").Value);
                            newStudent.Name = record.Element("Name").Value;
                            newStudent.Gender = Convert.ToChar(record.Element("Gender").Value);
                            newStudent.Age = Convert.ToInt32(record.Element("Age").Value);
                            newStudent.Grade = Convert.ToChar(record.Element("Grade").Value);
                            newStudent.Branch = record.Element("Branch").Value;
                            students.Add(newStudent);
                        }
                        catch (FormatException e)
                        {
                            Response.Write("<script>alert('Format conversion error')</script>");
                        }
                    }
                   
                }
                //bind the list into gridview
                GrdStudents.DataSource = students;
                GrdStudents.DataBind();
            }
            //if choice is grade D then make a list of those students
            if (choiceOfStudentList == 2)
            {
                char grade;
                foreach (var record in xDoc.Descendants("Student"))
                {
                    newStudent = new Student();
                    grade = Convert.ToChar(record.Element("Grade").Value);
                    if (grade == 'D')
                    {
                        newStudent.RollNo = Convert.ToInt32(record.Element("RollNo").Value);
                        newStudent.Name = record.Element("Name").Value;
                        newStudent.Gender = Convert.ToChar(record.Element("Gender").Value);
                        newStudent.Age = Convert.ToInt32(record.Element("Age").Value);
                        newStudent.Grade = Convert.ToChar(record.Element("Grade").Value);
                        newStudent.Branch = record.Element("Branch").Value;
                        students.Add(newStudent);
                    }  
                }
                //bind the list into gridview
                GrdStudents.DataSource = students;
                GrdStudents.DataBind();
            }
        }
    }
}