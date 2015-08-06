using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.DataAccess
{
    public static class StudentsOperations
    {
        static LibraryEntities entity = new LibraryEntities();
        //check if username is available
        public static bool IsUser(string username)
        {
            LibraryEntities entity = new LibraryEntities();
            var query = (from Student in entity.Students
                         where Student.Username == username
                         select Student).FirstOrDefault();
            if (query != null)
            {
                return true;
            }
            else
                return false;
        }
        //create a new user account
        public static void AddStudent(string username, string password, string name, int age, string gender, int rollno, string branch)
        {
            Student newStudent = new Student();
            newStudent.Username = username;
            newStudent.Password = password;
            newStudent.Name = name;
            newStudent.Age = age;
            newStudent.Gender = gender;
            newStudent.Rollno = rollno;
            newStudent.Branch = branch;
            entity.Students.Add(newStudent);
            entity.SaveChanges();
        }
        //method to show all record of single user
        public static Student ViewUser(string username)
        {
            var query = (from Student in entity.Students
                         where Student.Username == username
                         select Student).FirstOrDefault();
            return query;
        }
        //method to update a user
        public static bool IsUpdateStudent(string username, string password, string name, int age, string gender, int rollno, string branch)
        {
            var query = (from Student in entity.Students
                         where Student.Username == username
                         select Student).FirstOrDefault();
            query.Password = password;
            query.Name = name;
            query.Age = age;
            query.Gender = gender;
            query.Rollno = rollno;
            query.Branch = branch;
            entity.SaveChanges();
            return true;
        }
        //method to view list of all issued book of a student
        public static List<IssueDetail> ViewHistory(string username)
        {
            return (from IssueDetail in entity.IssueDetails
                    where IssueDetail.Issuer == username && IssueDetail.Status == "Issued"
                    select IssueDetail).ToList();
        }
        public static List<Student> GetStudent()
        {
            return (from Student in entity.Students
                    select Student).ToList();
        }
        public static List<Student> ViewStudent()
        {
            return (from Student in entity.Students
                    select Student).ToList();
        }
    }

}