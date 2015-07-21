using System;

namespace Assignment4
{
    class TestStrings
    {
        static void Main(string[] args)
        {
            String str1, str2, newstr;
            Console.WriteLine("Enter first String");
            str1 = Console.ReadLine();
            Console.WriteLine("Enter second String");
            str2 = Console.ReadLine();

            //Checking if string is null
            if (string.IsNullOrEmpty(str1))
            {
                Console.WriteLine("String is empty or null");
            }
            else
            {
                Console.WriteLine("String is not empty or null");
            }


            //length of strings
            Console.WriteLine("length of first string entered= " + str1.Length);
            Console.WriteLine("length of first string entered= " + str2.Length);


            //extracting a substring
            Console.WriteLine("finding substring");
            Console.WriteLine(str1.Substring(2));


            //concating two strings
            Console.WriteLine("concating strings:");
            Console.WriteLine(string.Concat(str1, str2));


            //comparing two strings
            Console.WriteLine("comparing strings:");
            if (String.Compare(str1, str2) == 0)
            {
                Console.WriteLine(str1 + " and " + str2 + " are equal.");
            }
            else
            {
                Console.WriteLine(str1 + " and " + str2 + " are not equal.");
            }


            //string contains another string
            if (str1.Contains(str2) == true)
            {
                Console.WriteLine("The string Contains() 'Second string' ");
            }
            else
            {
                Console.WriteLine("The String does not Contains() 'second string'");
            }

            //copy contents of one string to another
            newstr = string.Copy(str1);
            Console.WriteLine(newstr);

            //string ends with particular word
            if (str1.EndsWith("array") == true)
            {
                Console.WriteLine("The String EndsWith 'array': ");
            }
            else
            {
                Console.WriteLine("The String does not EndsWith 'array':");
            }


            //index of a substring in a string
            Console.WriteLine("Using IndexOf:");
            Console.WriteLine(str1.IndexOf("array").ToString());

            //to extract a substring froma string
            Console.WriteLine("Finding substring:");
            newstr = str1.Substring(1, 5);
            Console.WriteLine(newstr);
            Console.Read();
        }


    }
}

