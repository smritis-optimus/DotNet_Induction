using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Linq;

namespace Assignment26
{
    static public class UtilityClass
    {
        static public bool LoadStudents(string fileName)
        {
            List<Student> students = new List<Student>();
            //reading each element from xml file
            Student newStudent;
            XDocument xDoc = XDocument.Load(fileName);
            //read ever record within the Student tag and send the list for inserting into database
            foreach (var record in xDoc.Descendants("Student"))
            {
                newStudent = new Student();
                newStudent.RollNo = Convert.ToInt32(record.Element("RollNo").Value);
                newStudent.Name = record.Element("Name").Value;
                newStudent.Gender = Convert.ToChar(record.Element("Gender").Value);
                newStudent.Age = Convert.ToInt32(record.Element("Age").Value);
                newStudent.Stream = record.Element("Stream").Value;
                students.Add(newStudent);
            }
            if (Student.insertStudents(students))
                return true;
            else
                return false;

        }
    }
}