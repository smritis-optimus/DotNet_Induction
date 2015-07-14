using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    public class Student
    {

        string name;
        int roll, age;
        public void display(string n, int r, int a)
        {
            Console.WriteLine("Name : {0}", n);
            Console.WriteLine("Rollno : {0}", r);
            Console.WriteLine("Age : {0}", a);
        }
    }
    public class SchoolStudent : Student
    {
        public void stream(string s)
        {
            Console.WriteLine("Your Stream is  : {0}", s);

        }
        public static void Main(string[] args)
        {
            SchoolStudent ss1 = new SchoolStudent();
            ss1.display("Kavita", 10, 15);
            ss1.stream("Science");
            Console.Read();
        }
    }
    public class CollegeStudent : Student
    {
        public void semester(int s, int t)
        {
            Console.WriteLine("Semester  : {0}", s);
            Console.WriteLine("Subject opted  : {0}", t);

        }
        public static void Main(string[] args)
        {
            CollegeStudent cs1 = new CollegeStudent();
            cs1.display("kaviraj", 19, 22);
            cs1.semester(4, 6);
            Console.Read();
        }
    }
}
