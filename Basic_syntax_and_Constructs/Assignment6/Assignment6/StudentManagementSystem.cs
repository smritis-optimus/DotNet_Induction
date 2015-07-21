using System;

namespace Assignment6
{
    class StudentManagementSystem
    {
        string name;
        int rollno;
        float marks;

        public void grade(float x)
        {
            float avg;
            avg = (x / 1000) * 100;
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


        public void record()
        {
            Console.WriteLine("Student Name : " + name);
            Console.WriteLine("Student rollno : " + rollno);
            grade(marks);
        }

        public static void Main(string[] args)
        {
            StudentManagementSystem s1 = new StudentManagementSystem();
            StudentManagementSystem s2 = new StudentManagementSystem();
            StudentManagementSystem s3 = new StudentManagementSystem();
            StudentManagementSystem s4 = new StudentManagementSystem();
            StudentManagementSystem s5 = new StudentManagementSystem();
            s1.name = "Smriti";
            s1.rollno = 49;
            s1.marks = 820;
            s1.record();
            s2.name = "Arjun";
            s2.rollno = 2;
            s2.marks = 420;
            s2.record();
            s3.name = "Geeta";
            s3.rollno = 29;
            s3.marks = 910;
            s3.record();
            s4.name = "Rohit";
            s4.rollno = 37;
            s4.marks = 620;
            s4.record();
            s5.name = "Deepak";
            s5.rollno = 19;
            s5.marks = 700;
            s5.record();
            Console.Read();
        }
    }
}
