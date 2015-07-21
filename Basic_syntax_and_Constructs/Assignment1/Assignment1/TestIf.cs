using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class TestIf
    {
        static void Main(string[] args)
        {
            String lang;
            lang = Console.ReadLine();
            if (lang.Equals("VB"))
                Console.WriteLine("VB.NET:OOP,multithreaded & more!");
            else
                if (lang.Equals("C#"))
                    Console.WriteLine("C# is a fine language");
                else
                    Console.WriteLine("Well....Good luck with that!");
            Console.Read();
        }
    }
}
