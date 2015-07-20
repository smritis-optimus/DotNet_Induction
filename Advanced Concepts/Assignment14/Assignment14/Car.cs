using System;

namespace Assignment14
{
    class Car:Vehicle
    {
        static void main(string[] args)
        {
            Car c1 = new Car();
            c1.Name = "Scorpio";
            c1.Speed = 40;
            Car c2 = new Car();
            c2.Name = "Maruti";
            c2.Speed = 40;
            Car c3 = new Car();
            c3.Name = "Chevloret";
            c3.Speed = 50;
            int i = c1.CompareTo(c2);
            if (i == 0)
                Console.WriteLine("Both Objects are equal");
            else
                Console.WriteLine("Both objects are not equal");
            Console.WriteLine(c1.Equals(c3));
            Console.Read();


        }
    }
}
