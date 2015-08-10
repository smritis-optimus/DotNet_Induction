using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
namespace DesignPatternMVC.Model
{
    /// <summary>
    /// student model class
    /// </summary>
    public class StudentModel
    {
        public string Name { get; set; }
        public int Rollno { get; set; }
        public int Age { get; set; }
        public string Branch { get; set; }
        private ArrayList aList = new ArrayList();
        /// <summary>
        /// constructor to define the student model
        /// </summary>
        /// <param name="name">Name of Student</param>
        /// <param name="rollno">Roll no of Student</param>
        /// <param name="age">Age of Student</param>
        /// <param name="branch">Branch of Student</param>
        public StudentModel(string name, int rollno,int age, string branch)
        {
            Name = name;
            Rollno = rollno;
            Age = age;
            Branch = branch;
        }
        /// <summary>
        /// method to update the model
        /// </summary>
        /// <param name="name">Name of Student</param>
        /// <param name="rollno">Roll no of Student</param>
        /// <param name="age">Age of Student</param>
        /// <param name="branch">Branch of Student</param>
        public void UpdateModel(string name, int rollno, int age, string branch)
        {
            Name = name;
            Rollno = rollno;
            Age = age;
            Branch = branch;
            this.NotifyObservers();//call method to change the view of user
        }
        public void AddObserver(View.StudentView paramView)
        {
            aList.Add(paramView);
            this.NotifyObservers();//call method to change the view of user
        }
        public void RemoveObserver(View.StudentView paramView)
        {
            aList.Remove(paramView);
            this.NotifyObservers();//call method to change the view of user
        }
        public void NotifyObservers()
        {
            foreach (View.StudentView view in aList)
            {
                view.Update(this);//update each student
            }
        }
    }
}