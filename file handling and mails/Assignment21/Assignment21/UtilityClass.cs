using System;
using System.Collections.Generic;
using System.IO;

namespace Assignment21
{
    static public class UtilityClass
    {
        public static bool LoadFromCSV(string FileName)
        {
            StreamReader streamReaderObject = new StreamReader(FileName);
            //creating a list of students
            List<Student> students=new List<Student>();
            Student newStudent;
            string[] streamDataValues = null;
            while (!streamReaderObject.EndOfStream)
            {
                //reading every row of csv file
                string rowData = streamReaderObject.ReadLine().Trim();
                if (rowData.Length > 0)
                {
                    //removing all the commas
                    streamDataValues = rowData.Split(',');
                    newStudent = new Student();
                    newStudent.RollNo = Convert.ToInt32(streamDataValues[0]);
                    newStudent.Name = streamDataValues[1];
                    newStudent.Gender = Convert.ToChar(streamDataValues[2]);
                    newStudent.Age = Convert.ToInt32(streamDataValues[3]);
                    newStudent.Stream = streamDataValues[4];
                    //adding object to list
                    students.Add(newStudent);
                }
            }
            //calling function to insert values from list into database
            if(Student.insertStudents(students))
            {
                return true;
            }
            else 
                return false;

        }
    }
}