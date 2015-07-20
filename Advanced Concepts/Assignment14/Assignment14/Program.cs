using System;
using System.Collections.Generic;

namespace Assignment14
{
    class Vehicle : IComparable<Vehicle>, IEquatable<Vehicle>
    {
        public string Name { get; set; }
        public int Speed { get; set; }

        //Implementing IComparable and IEquatable Interface

        public int CompareTo(Vehicle other)
        {
            if (other == null)
                return -1;
            Vehicle v = other as Vehicle;
            return this.Speed.CompareTo(v.Speed);
        }


        public override int GetHashCode()
        {

            return this.Name.GetHashCode() ^ this.Speed.GetHashCode();
        }

        public bool Equals(Vehicle other)
        {
            if (other == null)
                return false;

            if (!(other is Vehicle))
                return false;
            Vehicle v = other as Vehicle;
            return Name == v.Name && Speed == v.Speed;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Vehicle Bike = new Vehicle();
            Vehicle Bicycle = new Vehicle();
            Vehicle Car = new Vehicle();
            Vehicle Truck = new Vehicle();
            Bike.Name = "Hero Honda";
            Bike.Speed = 40;
            Bicycle.Name = "Avon";
            Bicycle.Speed = 50;
            Car.Name = "Swift";
            Car.Speed = 45;
            Truck.Name = "Hardy";
            Truck.Speed = 30;

            //Adding objects to list
            List<Vehicle> VehicleList = new List<Vehicle>();
            VehicleList.Add(Bike);
            VehicleList.Add(Bicycle);
            VehicleList.Add(Car);
            VehicleList.Add(Truck);

            //Sorting the vehicles
            Console.WriteLine("\n--------------");
            Console.WriteLine("After Sorting->");
            VehicleList.Sort();
            foreach (Vehicle v in VehicleList)
                Console.WriteLine("Vehicle is: {0} , Speed : {1} ", v.Name, v.Speed);

            //1. Icomparator operator to comapre two objects.
            int i = Bike.CompareTo(Bicycle);
            if (i == 0)
                Console.WriteLine("Both Objects are equal");
            else
                Console.WriteLine("Both objects are not equal");

            //IEquatable to find equality of two objects
            Console.WriteLine(Car.Equals(Truck));
            Console.Read();


        }
    }
}
