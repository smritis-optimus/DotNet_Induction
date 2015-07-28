using System.Collections.Generic;

namespace Assignment21
{
    public class Student
    {
        private int _rollno;
        private string _name;
        private char _gender;
        private int _age;
        private string _stream;

        public int RollNo
        {
            get
            {
                return _rollno;
            }
            set
            {
                _rollno = value;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public char Gender
        {
            get
            {
                return _gender;
            }
            set
            {
                _gender = value;
            }
        }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }
        public string Stream
        {
            get
            {
                return _stream;
            }
            set
            {
                _stream = value;
            }
        }
        public static bool insertStudents(List<Student> studentsData)
        {
            //calling the function of StudentHandler Class
            if (StudentDataHandler.insertStudents(studentsData))
                return true;
            else
                return false;
        }
    }
}