using System;

namespace Vehicle
{
   public class Vehicle
    {
        public string make, model;
        public int yearOfManufacture;
        public float speed;
        public Vehicle(string m, string o, int y, float s)
        {
            make = m;
            model = o;
            yearOfManufacture = y;
            speed = s;
        }
        public void Accelerate()
        {
            speed = speed + 10;
            Console.WriteLine("{0} Accelerated to: {1}", make, speed);
        }
        public void Deaccelerate()
        {
            speed = speed - 10;
            Console.WriteLine("{0} Deccelerated to: {1}", make, speed);
        }

        public void Stop()
        {
            speed = 0;
            Console.WriteLine("{0} stopped", make);
        }
        public Boolean isMoving()
        {
            if (speed != 0)
                return true;
            else
                return false;
        }
        public void display()
        {
            Console.WriteLine("\nVehicle : {0}", make);
            Console.WriteLine("\nModel : {0}", model);
            Console.WriteLine("\nManufactured in : {0}", yearOfManufacture);
            Console.WriteLine("\nSpeed : {0}", speed);
        
        }
    }
    public class Bicycle : Vehicle
    {

        public void accomodation()
        {
            Console.WriteLine("For 1 person Only");
        }
        public Bicycle(string m, string o, int y, float s)
            : base(m, o, y, s)
        { }
        public static void Main(string[] args)
        {
            int ch = 1;
            Bicycle b1 = new Bicycle("bicycle", "101", 2012, 15);

            while (ch != 7)
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
                ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1: b1.Accelerate();
                        break;
                    case 2: b1.Deaccelerate();
                        break;
                    case 3: b1.Stop();
                        break;
                    case 4:
                        {
                            if (b1.isMoving() == true)
                                Console.WriteLine("Moving");
                            else
                                Console.WriteLine("Not Moving");
                        }
                        break;
                    case 5: b1.display();
                        break;
                    case 6: b1.accomodation();
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
        public void accomodation()
        {
            Console.WriteLine("For 2 persons");
        }
        public static void Main(string[] args)
        {
            int ch = 1;
            Bike b1 = new Bike("bike", "102", 2013, 60);
            while (ch != 7)
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
                ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1: b1.Accelerate();
                        break;
                    case 2: b1.Deaccelerate();
                        break;
                    case 3: b1.Stop();
                        break;
                    case 4:
                        {
                            if (b1.isMoving() == true)
                                Console.WriteLine("Moving");
                            else
                                Console.WriteLine("Not Moving");
                        }
                        break;
                    case 5: b1.display();
                        break;
                    case 6: b1.accomodation();
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
        public void isRacing()
        {
            if (speed > 70)
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
                            if (c1.isMoving() == true)
                                Console.WriteLine("Moving");
                            else
                                Console.WriteLine("Not Moving");
                        }
                        break;
                    case 5: c1.display();
                        break;
                    case 6: c1.isRacing();
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
        int num = 10;
        public Truck(string m, string o, int y, float s)
            : base(m, o, y, s)
        { }
        public void goods()
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
                            if (t1.isMoving() == true)
                                Console.WriteLine("Moving");
                            else
                                Console.WriteLine("Not Moving");
                        }
                        break;
                    case 5: t1.display();
                        break;
                    case 6: t1.goods();
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
