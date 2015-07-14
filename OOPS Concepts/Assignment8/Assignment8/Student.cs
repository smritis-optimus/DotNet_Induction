using System;

namespace Assignment8
{
    class Student
    {
        private string name, course;
        private int enroll, age;
        public void set_name(string value)
        {
          name = value;
        }
        public void set_course(string value)
        {
         course = value;
        }
        public void set_enroll(int value)
        {
        enroll = value;
        }
        public void set_name(int value)
        {
         age = value;
        }

        enum attr
        {
            name, enroll, age, course
        }
        public Student(string n, int e, int a, string c)
        {
            name = n;
            enroll = e;
            age = a;
            course = c;

        }

        public void display()
        {
            Console.WriteLine("Welcome {0} \n Enrollment no : {1} \n Age : {2} \n Course : {3} \n", name, enroll, age, course);

        }

        public void print()
        {
            Console.WriteLine(" \n Enrollment no : {1} \n Age : {2} \n Course : {3} \n", name, enroll, age, course);


        }


        public void print(int choice)
        {
            attr ch = (attr)choice;
            switch (ch)
            {
                case attr.name:
                    Console.WriteLine("Name is : {0} ", name);
                    break;
                case attr.enroll:
                    Console.WriteLine("Enrollment no. is : {0} ", enroll);
                    break;
                case attr.age:
                    Console.WriteLine("Age is : {0} ", age);
                    break;
                case attr.course:
                    Console.WriteLine("Course is {0} ", course);
                    break;

                default: Console.WriteLine("Invalid choice");
                    break;
            }
        }


        public static void Main(string[] args)
        {
            int val;
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
            val = Convert.ToInt32(Console.ReadLine());

            s1.print(val - 1);

            Console.Read();
        }


    }
}
