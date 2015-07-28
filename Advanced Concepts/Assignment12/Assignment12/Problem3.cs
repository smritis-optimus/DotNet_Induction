using System;
using System.Collections;
using System.Collections.Generic;

namespace Assignment12
{
    class VehicleCollection : IEnumerable<string>
    {
        private List<string> _elements;

        public VehicleCollection(string[] array)
        {
            this._elements = new List<string>(array);
        }

        IEnumerator<string> IEnumerable<string>.GetEnumerator()
        {
            Console.WriteLine("\n..........");
            Console.WriteLine("\nItems in vehicle Collection");
            return this._elements.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this._elements.GetEnumerator();
        }
    }

    class Problem3
    {
        static void Main()
        {
            VehicleCollection v = new VehicleCollection(
                new string[] { "Bicycle", "Bike", "Car", "Truck" });

            foreach (string element in v)
            {
                Console.WriteLine(element);
            }
            Console.Read();
        }
    }
}