using System;

namespace Vehicle
{
    public class Vehicle
    {
        public string _vehicleName, _vehicleModel;
        public int _yearOfManufacture;
        public float _speedofVehicle;
        public Vehicle(string m, string o, int y, float s)
        {
            _vehicleName = m;
            _vehicleModel = o;
            _yearOfManufacture = y;
            _speedofVehicle = s;
        }
        public void Accelerate()
        {
            _speedofVehicle = _speedofVehicle + 10;
            Console.WriteLine("{0} Accelerated to: {1}", _vehicleName, _speedofVehicle);
        }
        public void Deaccelerate()
        {
            _speedofVehicle = _speedofVehicle - 10;
            Console.WriteLine("{0} Deccelerated to: {1}", _vehicleName, _speedofVehicle);
        }

        public void Stop()
        {
            _speedofVehicle = 0;
            Console.WriteLine("{0} stopped", _vehicleName);
        }
        public Boolean IsMoving()
        {
            if (_speedofVehicle != 0)
                return true;
            else
                return false;
        }
        public void Display()
        {
            Console.WriteLine("\nVehicle : {0}", _vehicleName);
            Console.WriteLine("\nModel : {0}", _vehicleModel);
            Console.WriteLine("\nManufactured in : {0}", _yearOfManufacture);
            Console.WriteLine("\nSpeed : {0}", _speedofVehicle);

        }
    }
    public class Bicycle : Vehicle
    {
        public void Accomodation()
        {
            Console.WriteLine("For 1 person Only");
        }
        public Bicycle(string m, string o, int y, float s)
            : base(m, o, y, s)
        { }
        public static void Main(string[] args)
        {
            int _ch = 1;
            Bicycle b1 = new Bicycle("bicycle", "101", 2012, 15);
            while (_ch != 7)
            {
                Console.WriteLine("\n.................");
                Console.WriteLine("Options:\n");
                Console.WriteLine("1.Accelerate your vehicle");
                Console.WriteLine("2.Deacclerate your vehicle");
                Console.WriteLine("3.Stop your vehicle");
                Console.WriteLine("4.Is your vehicle moving?");
                Console.WriteLine("5.Display all details");
                Console.WriteLine("6..Passengers");
                Console.WriteLine("7.Exit");
                Console.WriteLine("Enter your Choice");
                _ch = int.Parse(Console.ReadLine());
                switch (_ch)
                {
                    case 1: b1.Accelerate();
                        break;
                    case 2: b1.Deaccelerate();
                        break;
                    case 3: b1.Stop();
                        break;
                    case 4:
                        {
                            if (b1.IsMoving() == true)
                                Console.WriteLine("Moving");
                            else
                                Console.WriteLine("Not Moving");
                        }
                        break;
                    case 5: b1.Display();
                        break;
                    case 6: b1.Accomodation();
                        break;
                    case 7: Console.WriteLine("Exited");
                        break;
                    default: Console.WriteLine("Incorrect option");
                        break;
                }

            }

            Console.Read();
        }
    }
    public class Bike : Vehicle
    {
        public Bike(string m, string o, int y, float s)
            : base(m, o, y, s)
        { }
        public void Accomodation()
        {
            Console.WriteLine("For 2 persons");
        }
        public static void Main(string[] args)
        {
            int _ch = 1;
            Bike b1 = new Bike("bike", "102", 2013, 60);
            while (_ch != 7)
            {
                Console.WriteLine("\n.................");
                Console.WriteLine("Options:\n");
                Console.WriteLine("1.Accelerate your vehicle");
                Console.WriteLine("2.Deacclerate your vehicle");
                Console.WriteLine("3.Stop your vehicle");
                Console.WriteLine("4.Is your vehicle moving?");
                Console.WriteLine("5.Display all details");
                Console.WriteLine("6..Passengers");
                Console.WriteLine("7.Exit");
                Console.WriteLine("Enter your Choice");
                _ch = int.Parse(Console.ReadLine());
                switch (_ch)
                {
                    case 1: b1.Accelerate();
                        break;
                    case 2: b1.Deaccelerate();
                        break;
                    case 3: b1.Stop();
                        break;
                    case 4:
                        {
                            if (b1.IsMoving() == true)
                                Console.WriteLine("Moving");
                            else
                                Console.WriteLine("Not Moving");
                        }
                        break;
                    case 5: b1.Display();
                        break;
                    case 6: b1.Accomodation();
                        break;
                    case 7: Console.WriteLine("Exited");
                        break;
                    default: Console.WriteLine("Incorrect option");
                        break;
                }
            }

            Console.Read();
        }
    }
    public class Car : Vehicle
    {

        public Car(string m, string o, int y, float s)
            : base(m, o, y, s)
        { }
        public void IsRacing()
        {
            if (_speedofVehicle > 70)
                Console.WriteLine("Racing Car");
            else
                Console.WriteLine("Not RacingCar");
        }
        public static void Main(string[] args)
        {
            int ch = 1;
            Car c1 = new Car("car", "103", 2014, 65);
            while (ch != 7)
            {
                Console.WriteLine("\n.................");
                Console.WriteLine("Options:\n");
                Console.WriteLine("1.Accelerate your vehicle");
                Console.WriteLine("2.Deacclerate your vehicle");
                Console.WriteLine("3.Stop your vehicle");
                Console.WriteLine("4.Is your vehicle moving?");
                Console.WriteLine("5.Display all details");
                Console.WriteLine("6.Is this a racing Car?");
                Console.WriteLine("7.Exit");
                Console.WriteLine("Enter your Choice");
                ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1: c1.Accelerate();
                        break;
                    case 2: c1.Deaccelerate();
                        break;
                    case 3: c1.Stop();
                        break;
                    case 4:
                        {
                            if (c1.IsMoving() == true)
                                Console.WriteLine("Moving");
                            else
                                Console.WriteLine("Not Moving");
                        }
                        break;
                    case 5: c1.Display();
                        break;
                    case 6: c1.IsRacing();
                        break;
                    case 7: Console.WriteLine("Exited");
                        break;
                    default: Console.WriteLine("Incorrect option");
                        break;
                }

            }
            Console.Read();
        }
    }
    public class Truck : Vehicle
    {
        private int _num = 10;
        public Truck(string m, string o, int y, float s)
            : base(m, o, y, s)
        { }
        public void Goods()
        {
            Console.WriteLine("Goods taken on a day : {0}", num);
        }
        public static void Main(string[] args)
        {
            int ch = 1;
            Truck t1 = new Truck("truck", "104", 2015, 70);
            while (ch != 7)
            {
                Console.WriteLine("\n.................");
                Console.WriteLine("Options:\n");
                Console.WriteLine("1.Accelerate your vehicle");
                Console.WriteLine("2.Deacclerate your vehicle");
                Console.WriteLine("3.Stop your vehicle");
                Console.WriteLine("4.Is your vehicle moving?");
                Console.WriteLine("5.Display all details");
                Console.WriteLine("6..Goods Taken");
                Console.WriteLine("7.Exit");
                Console.WriteLine("Enter your Choice");
                ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1: t1.Accelerate();
                        break;
                    case 2: t1.Deaccelerate();
                        break;
                    case 3: t1.Stop();
                        break;
                    case 4:
                        {
                            if (t1.IsMoving() == true)
                                Console.WriteLine("Moving");
                            else
                                Console.WriteLine("Not Moving");
                        }
                        break;
                    case 5: t1.Display();
                        break;
                    case 6: t1.Goods();
                        break;
                    case 7: Console.WriteLine("Exited");
                        break;
                    default: Console.WriteLine("Incorrect option");
                        break;
                }

            }
            Console.Read();
        }
    }
}
