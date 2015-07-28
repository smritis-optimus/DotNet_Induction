
namespace Assignment25
{
    public class Student
    {
        private int _rollno;
        private string _name;
        private char _gender;
        private int _age;
        private string _branch;
        private char _grade;

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
        public string Branch
        {
            get
            {
                return _branch;
            }
            set
            {
                _branch = value;
            }
        }
        public char Grade
        {
            get
            {
                return _grade;
            }
            set
            {
                _grade = value;
            }
        }
    }
}