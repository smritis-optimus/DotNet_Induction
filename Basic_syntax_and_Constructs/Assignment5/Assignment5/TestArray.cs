using System;

namespace Assignment5
{
    class TestArray
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(string.Join(" ", getStringArray()));
            Console.Read();
        }


        public static String[] getStringArray()
        {
            string[] array = new string[6];
            array[0] = "This";
            array[1] = "is";
            array[2] = "an";
            array[3] = "array";
            array[4] = "of";
            array[5] = "string";
            return array;
        }
    }
}
