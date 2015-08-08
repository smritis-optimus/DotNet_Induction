using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.DataAccess
{
    public static class StudentsOperations
    {
        /// <summary>
        /// method to check if username is available for new account creation
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static bool IsUser(string username)
        {
            try
            {
                using (LibraryEntities entity = new LibraryEntities())
                {
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
            }
            catch (Exception e)
            {
                return false;
            }
        }
        /// <summary>
        /// method to create a new student account
        /// </summary>
        /// <param name="username">Unique username</param>
        /// <param name="password">Student password</param>
        /// <param name="name">Student name</param>
        /// <param name="age">Age of student</param>
        /// <param name="gender">Gender of student</param>
        /// <param name="rollno">Rollno of Student</param>
        /// <param name="branch">Branch of Student</param>
        public static void AddStudent(string username, string password, string name, int age, string gender, int rollno, string branch)
        {
            try
            {
                Student newStudent = new Student();
                newStudent.Username = username;
                newStudent.Password = password;
                newStudent.Name = name;
                newStudent.Age = age;
                newStudent.Gender = gender;
                newStudent.Rollno = rollno;
                newStudent.Branch = branch;
                using (LibraryEntities entity = new LibraryEntities())
                {
                    entity.Students.Add(newStudent);
                    entity.SaveChanges();
                }
            }
            catch (Exception e)
            {
            }
        }
        /// <summary>
        /// method to show all records to single user
        /// </summary>
        /// <param name="username">Current user obtained from session</param>
        /// <returns></returns>
        public static Student GetUser(string username)
        {
            try
            {
                using (LibraryEntities entity = new LibraryEntities())
                {
                    var query = (from Student in entity.Students
                                  where Student.Username==username

                                 select Student).FirstOrDefault();
                    if (query != null)
                    {
                        return query;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
        /// <summary>
        /// method to update a student and return true is update is successful
        /// </summary>
        /// <param name="username">Username of student</param>
        /// <param name="password">Student password</param>
        /// <param name="name">Student name</param>
        /// <param name="age">Age of student</param>
        /// <param name="gender">Gender of student</param>
        /// <param name="rollno">Rollno of Student</param>
        /// <param name="branch">Branch of Student</param>
        /// <returns></returns>
        public static bool IsUpdateStudent(string username, string password, string name, int age, string gender, int rollno, string branch)
        {
            try
            {
                using (LibraryEntities entity = new LibraryEntities())
                {
                    var query = (from Student in entity.Students
                                 where Student.Username == username
                                 select Student).FirstOrDefault();
                    if (query != null)
                    {
                        query.Password = password;
                        query.Name = name;
                        query.Age = age;
                        query.Gender = gender;
                        query.Rollno = rollno;
                        query.Branch = branch;
                        entity.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }
        /// <summary>
        /// method to get the history of all issues by a single student
        /// </summary>
        /// <param name="username">Current user obtained from session</param>
        /// <returns></returns>
        public static List<IssueDetail> GetHistory(string username)
        {
            try
            {
                using (LibraryEntities entity = new LibraryEntities())
                {
                    return (from IssueDetail in entity.IssueDetails
                            where IssueDetail.Issuer == username
                            select IssueDetail).ToList();
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
        /// <summary>
        /// method to get history of all issues by all students.
        /// </summary>
        /// <returns></returns>
        public static List<Student> GetStudentsWithIssuingHistory()
        {
            try
            {
                LibraryEntities entity = new LibraryEntities();               
                   return (from Student in entity.Students
                             join IssueDetail in entity.IssueDetails
                             on Student.Username equals IssueDetail.Issuer
                             select Student).ToList();                           
            }
            catch (Exception e)
            {
                return null;
            }

        }
        /// <summary>
        /// method to get the list of all students
        /// </summary>
        /// <returns></returns>
        public static List<Student> GetStudents()
        {
            try
            {
                using (LibraryEntities entity = new LibraryEntities())
                {
                    return (from Student in entity.Students
                            select Student).ToList();
                }
            }
            catch (Exception e)
            {
                return null;
            }

        }
        /// <summary>
        /// method to delete a student from database
        /// </summary>
        /// <param name="username">Username of student</param>
        public static void DeleteStudent(string username)
        {
            try
            {
                using (LibraryEntities entity = new LibraryEntities())
                {
                    var query = (from Student in entity.Students
                                 where Student.Username == username
                                 select Student).FirstOrDefault();
                    if (query != null)
                    {
                        entity.Students.Remove(query);
                        entity.SaveChanges();
                    }
                }
            }
            catch (Exception e)
            {
            }
        }
        /// <summary>
        /// method to get books that are issued
        /// </summary>
        /// <returns></returns>
        public static List<Book> GetIssuedBooks()
        {
            LibraryEntities entity = new LibraryEntities();
            var query = (from IssueDetail in entity.IssueDetails
                         join Book in entity.Books
                          on IssueDetail.Book equals Book
                         select Book).ToList();
            return query;
        }
    }

}