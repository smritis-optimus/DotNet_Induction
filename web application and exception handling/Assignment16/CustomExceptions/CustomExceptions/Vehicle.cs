using System;

namespace CustomExceptions
{
    public class Vehicle
    {
        public string name{get;set;} 
        public string model{get;set;}
        public int yearOfManufacture{get;set;}
        public int speed{get;set;}
        public Vehicle(string m, string o, int y,int s)
        {
            name = m;
            model = o;
            yearOfManufacture = y;
            speed = s;
        }
        public void Accelerate()
        {
            try
            {

                if (name.Equals("bicycle") && speed > 90)
                {
                    throw new Exception();
                }
                else if (speed < 0)
                {
                    throw new DivideByZeroException();
                 
                }
                else if (name.Equals("car") && speed > 40)
                {
                    throw new IsCarDeadException("Car is overheated", speed);
                }
                else
                {
                    speed = speed + 10;
                    Console.WriteLine("{0} Accelerated to: {1}", name, speed);
                }
            }
            catch (DivideByZeroException e)
            {
                ExceptionUtility.LogException(e, "Speed cannot be negative");
            }
            catch (Exception e)
            {
                ExceptionUtility.LogException(e, "Speed of bicycle cannot exceed more than 100");
            }
                 
        }
        public void Deaccelerate()
        {
            try
            {

                if (speed < 10)
                {
                  throw new Exception();
                }
                else
                {
                    speed = speed - 10;
                    Console.WriteLine("{0} Deccelerated to: {1}", name, speed);
                }
            }
                 catch (Exception e)
            {
                ExceptionUtility.LogException(e, "Speed cannot be deaccelerated to negative");
            }
            
        }
   public void display()
        {
            Console.WriteLine("\nVehicle : {0}", name);
            Console.WriteLine("\nModel : {0}", model);
            Console.WriteLine("\nManufactured in : {0}", yearOfManufacture);
            Console.WriteLine("\nSpeed : {0}", speed);

        }

       
        public static void Main(string[] main)
        {
            Vehicle Bike = new Vehicle("bike", "102", 2013, 5);
            Vehicle Bicycle = new Vehicle("bicycle", "101", 2012, -5);
            Vehicle Car = new Vehicle("car", "103", 2014, 65);
            Vehicle Truck = new Vehicle("truck", "104", 2015, 70);
            Bike.Deaccelerate();
           Bicycle.Accelerate();
          Car.Accelerate();
            Console.ReadLine();
        }

    }
}
