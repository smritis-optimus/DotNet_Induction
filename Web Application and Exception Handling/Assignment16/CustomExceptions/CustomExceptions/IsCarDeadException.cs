using System;

namespace CustomExceptions
{
    class IsCarDeadException : Exception
    {
        public IsCarDeadException(string message,int speed)
            : base(message)
        {
            Console.WriteLine("{0} at time : {1} and speed : {2}", message, DateTime.Now,speed);
        }
       
    }
}
