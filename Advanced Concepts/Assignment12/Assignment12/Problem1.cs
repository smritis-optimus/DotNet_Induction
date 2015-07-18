using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment12
{
    public class Vehicle : IComparable<Vehicle>
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int YearOfManufacture { get; set; }
        public int Speed { get; set; }


        public int CompareTo(Vehicle other)
        {
            return this.Make.CompareTo(other.Make);
        }

        //2. Override equals method to check two vehicles for equality
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (!(obj is Vehicle))
                return false;
            Vehicle v = obj as Vehicle;
            return Make == v.Make && Model == v.Model;
        }
        public override int GetHashCode()
        {

            return this.Make.GetHashCode() ^ this.Model.GetHashCode() ^ this.YearOfManufacture.GetHashCode() ^ this.Speed.GetHashCode();
        }
    }

    class Problem1
    {

        public static void Main(string[] args)
        {
            Vehicle Bike = new Vehicle();
            Bike.Make = "Bike";
            Bike.Model = "101";
            Bike.YearOfManufacture = 2012;
            Bike.Speed = 40;
            Vehicle Bicycle = new Vehicle();
            Bicycle.Make = "Bicycle";
            Bicycle.Model = "102";
            Bicycle.YearOfManufacture = 2013;
            Bicycle.Speed = 30;
            Vehicle Car = new Vehicle();
            Car.Make = "Car";
            Car.Model = "103";
            Car.YearOfManufacture = 2011;
            Car.Speed = 50;
            Vehicle Truck = new Vehicle();
            Truck.Make = "Truck";
            Truck.Model = "104";
            Truck.YearOfManufacture = 2015;
            Truck.Speed = 60;
            List<Vehicle> VehicleList = new List<Vehicle>(100);
            VehicleList.Add(Bike);
            VehicleList.Add(Bicycle);
            VehicleList.Add(Car);
            VehicleList.Add(Truck);

            //1. Icomparator operator to comapre two objects.

            int i = Bike.CompareTo(Bicycle);
            if (i == 0)
                Console.WriteLine("Both Objects are equal");
            else
                Console.WriteLine("Both objects are not equal");

            //Sorting the vehicles
            Console.WriteLine("\n--------------");
            Console.WriteLine("After Sorting->");
            VehicleList.Sort();
            foreach (Vehicle v in VehicleList)
                Console.WriteLine("Vehicle is: {0} , Model : {1} , Year : {2} ,Speed : {3} ", v.Make, v.Model, v.YearOfManufacture, v.Speed);

            // Printing all objects
            Console.WriteLine("\n--------------");
            Console.WriteLine("Printing Status of Objects->");
            foreach (Vehicle v in VehicleList)
                Console.WriteLine("Vehicle is: {0} , Status : {1} , Year : {2} ,Speed : {3} ", v.Make, v.Model, v.YearOfManufacture, v.Speed);

            // Implementing Equals method
            Console.WriteLine("\n--------------");
            Console.WriteLine(Bike.Equals(Car));

            Console.Read();

        }

    }
}
