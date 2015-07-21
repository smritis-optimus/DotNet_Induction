using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    public class Student
    {

        public string Name;
        int Roll, Age;
        public void Display(string n, int r, int a)
        {
            Console.WriteLine("Name : {0}", n);
            Console.WriteLine("Rollno : {0}", r);
            Console.WriteLine("Age : {0}", a);
        }
    }
    public class SchoolStudent : Student
    {
        public void Stream(string s)
        {
            Console.WriteLine("Your Stream is  : {0}", s);

        }
        public static void Main(string[] args)
        {
            SchoolStudent ss1 = new SchoolStudent();
            ss1.Display("Kavita", 10, 15);
            ss1.Stream("Science");
            Console.Read();
        }
    }
    public class CollegeStudent : Student
    {
        int _enroll=78;
        public void Semester(int s, int t)
        {
            Console.WriteLine("Enrollment no : {0}", _enroll);
            Console.WriteLine("Semester  : {0}", s);
            Console.WriteLine("Subject opted  : {0}", t);

        }
        public static void Main(string[] args)
        {
            CollegeStudent cs1 = new CollegeStudent();
            cs1.Display("kaviraj", 19, 22);
            cs1.Semester(4, 6);
            Console.Read();
        }
    }
}
