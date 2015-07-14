using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class TestSwitch
    {
        static void Main(string[] args)
        {
            String lang;
            lang = Console.ReadLine();
            switch (lang)
            {
                case ("VB"): Console.WriteLine("VB.NET:OOP,multithreaded & more!"); break;
                case ("C#"): Console.WriteLine("C# is a fine language"); break;
                default: Console.WriteLine("Well....Good luck with that!"); break;
            }
            Console.Read();
        }
    }
}
