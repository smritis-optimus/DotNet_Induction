using System;

namespace Assignment8
{
    class Student
    {
        private string _name, _course;
        private int _enroll, _age;
        public void set_name(string value)
        {
            _name = value;

        }
        public void set_course(string value)
        {
            _course = value;
        }
        public void set_enroll(int value)
        {
            _enroll = value;
        }
        public void set_name(int value)
        {
            _age = value;
        }

        enum Attr
        {
            name, enroll, age, course
        }
        public Student(string n, int e, int a, string c)
        {
            _name = n;
            _enroll = e;
            _age = a;
            _course = c;

        }

        public void display()
        {
            Console.WriteLine("Welcome {0} \n Enrollment no : {1} \n Age : {2} \n Course : {3} \n", name, _enroll, _age, _course);

        }

        public void print()
        {
            Console.WriteLine(" \n Enrollment no : {1} \n Age : {2} \n Course : {3} \n", name, _enroll, _age, _course);


        }


        public void print(int choice)
        {
            Attr ch = (Attr)choice;
            switch (ch)
            {
                case Attr.name:
                    Console.WriteLine("Name is : {0} ", _name);
                    break;
                case Attr.enroll:
                    Console.WriteLine("Enrollment no. is : {0} ", _enroll);
                    break;
                case Attr.age:
                    Console.WriteLine("Age is : {0} ", _age);
                    break;
                case Attr.course:
                    Console.WriteLine("Course is {0} ", _course);
                    break;

                default: Console.WriteLine("Invalid choice");
                    break;
            }
        }


        public static void Main(string[] args)
        {
            int _val;
            Student s1 = new Student("Priya", 40, 20, "Medicine");
            Student s2 = new Student("Pankaj", 36, 19, "Forensics");
            Random rnd = new Random();
            int roll = rnd.Next(1, 100);
            Console.WriteLine("Random enrollment no:{0} ", roll);
            Console.WriteLine("----------------\n");
            Console.WriteLine("Welcome with details:");
            s1.display();
            Console.WriteLine("\n----------------");
            Console.WriteLine("All details without choice:");
            s1.print();
            Console.WriteLine("----------------\n");
            Console.WriteLine("Student Attribute:");
            Console.Write("\n 1-Name\n 2-Enrollment no\n 3-Age\n 4-Course\nPlease select one : 1,2,3 or 4");
            _val = Convert.ToInt32(Console.ReadLine());

            s1.print(_val - 1);

            Console.Read();
        }


    }
}
