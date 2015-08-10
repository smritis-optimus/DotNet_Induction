using System;

namespace DesignPatternSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constructor is protected -- cannot use new 
            Singleton s1 = Singleton.Instance();
            Singleton s2 = Singleton.Instance();

            if (s1 == s2)
            {
                Console.WriteLine("Objects are the same instance");
            }
            s1.Print("Singleton object created");

            // Wait for user 
            Console.Read();
        }
    }
    // "Singleton" 
    class Singleton
    {
        private static Singleton instance;

        // Note: Constructor is 'protected' 
        protected Singleton()
        {
        }

        public static Singleton Instance()
        {
            // Use 'Lazy initialization' 
            if (instance == null)
            {
                instance = new Singleton();
            }

            return instance;
        }
        public void Print(string s)
        {
            Console.WriteLine(s);
        }
    }
}
