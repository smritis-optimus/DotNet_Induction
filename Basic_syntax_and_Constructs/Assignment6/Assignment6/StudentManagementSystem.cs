using System;

namespace Assignment6
{
    class StudentManagementSystem
    {
        string _name;
        int _rollno;
        float _marks;

        public void CalculateGrade(float marks)
        {
            float avg;
            avg = (marks / 1000) * 100;
            if (avg >= 75)
                Console.WriteLine("Distinction");
            else
                if (avg >= 60)
                    Console.WriteLine("First Division");
                else if (avg >= 50)
                    Console.WriteLine("Second Division");
                else if (avg >= 40)
                    Console.WriteLine("Third Division");
                else
                    Console.WriteLine("Fail");
        }


        public void DisplayRecord()
        {
            Console.WriteLine("Student Name : " + _name);
            Console.WriteLine("Student rollno : " + _rollno);
            CalculateGrade(_marks);
        }

        public static void Main(string[] args)
        {
            StudentManagementSystem s1 = new StudentManagementSystem();
            StudentManagementSystem s2 = new StudentManagementSystem();
            StudentManagementSystem s3 = new StudentManagementSystem();
            StudentManagementSystem s4 = new StudentManagementSystem();
            StudentManagementSystem s5 = new StudentManagementSystem();
            s1._name = "Smriti";
            s1._rollno = 49;
            s1._marks = 820;
            s1.DisplayRecord();
            s2._name = "Arjun";
            s2._rollno = 2;
            s2._marks = 420;
            s2.DisplayRecord();
            s3._name = "Geeta";
            s3._rollno = 29;
            s3._marks = 910;
            s3.DisplayRecord();
            s4._name = "Rohit";
            s4._rollno = 37;
            s4._marks = 620;
            s4.DisplayRecord();
            s5._name = "Deepak";
            s5._rollno = 19;
            s5._marks = 700;
            s5.DisplayRecord();
            Console.Read();
        }
    }
}
