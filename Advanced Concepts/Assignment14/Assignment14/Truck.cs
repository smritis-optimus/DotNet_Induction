using System;

namespace Assignment14
{
    class Truck:Vehicle
    {
        static void main(string[] args)
        {
            Truck t1 = new Truck();
            t1.Name = "Dodge";
            t1.Speed = 60;
            Truck t2 = new Truck();
            t2.Name = "Blazer";
            t2.Speed = 65;
            Truck t3 = new Truck();
            t3.Name = "Dodge";
            t3.Speed = 60;
            int i = t1.CompareTo(t2);
            if (i == 0)
                Console.WriteLine("Both Objects are equal");
            else
                Console.WriteLine("Both objects are not equal");
            Console.WriteLine(t1.Equals(t3));
            Console.Read();

        }
    }
}
