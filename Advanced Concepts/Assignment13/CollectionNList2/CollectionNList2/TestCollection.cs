using System;
using System.Collections;

namespace CollectionNList2
{

    class Vehicle
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public override string ToString()
        {
            Console.WriteLine("\nUsing ToString");
            return this.Name + " " + this.Model;
        }
    }
    class TestCollection
    {
        static void Main()
        {
            Vehicle v1 = new Vehicle();
            v1.Name = "Bike";
            v1.Model = "101";
            Vehicle v2 = new Vehicle();
            v2.Name = "Bicycle";
            v2.Model = "102";
            Vehicle v3 = new Vehicle();
            v3.Name = "Car";
            v3.Model = "103";
            Vehicle v4 = new Vehicle();
            v4.Name = "Truck";
            v4.Model = "104";

            //1.Creating list as VehicleList
            ArrayList VehicleList = new ArrayList();

            //2.Adding objects to list
            VehicleList.Add(v1);
            VehicleList.Add(v2);
            VehicleList.Add(v3);
            VehicleList.Add(v4);

            //3.enumerating through each object and using ToString to display
            Console.WriteLine("\nDisplaying objects->");
            foreach (Vehicle v in VehicleList)
            {
                Console.WriteLine("Vehicle Name : {0} Model : {1}", v.Name, v.Model);
            }

            //4.get list element using index
            Console.WriteLine("\nDisplaying objects using index->");
            for (int i = 0; i < VehicleList.Count; i++)
                Console.WriteLine("Vehicle Name : {0} Model : {1}", ((Vehicle)VehicleList[i]).Name, ((Vehicle)VehicleList[i]).Model);

            Console.WriteLine(Convert.ToString(v1));
            Console.Read();
        }
    }
}
