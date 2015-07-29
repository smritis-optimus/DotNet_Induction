using System;

namespace Assignment28
{
    [Serializable()]
    public class Student
    {
        private int _rollno;
        private string _name;
        private int _totalmarks;
        [NonSerialized()]
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
        public int TotalMarks
        {
            get
            {
                return _totalmarks;
            }
            set
            {
                _totalmarks = value;
            }
        }

        public char Grade
        {
            get
            {
                if (TotalMarks >= 90 && TotalMarks < 100)
                    return ('A');
                else if (TotalMarks >= 80 && TotalMarks < 90)
                    return ('B');
                else if (TotalMarks >= 60 && TotalMarks < 80)
                    return ('C');
                else if (TotalMarks < 60)
                    return ('D');
                else
                    return ('F');
            }
        }
    }
}
