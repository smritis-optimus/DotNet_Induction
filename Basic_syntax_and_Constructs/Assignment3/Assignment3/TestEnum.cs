﻿using System;

namespace Assignment3
{
    class TestEnum
    {
        enum WeekDays
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enum \n");
            Console.WriteLine(WeekDays.Sunday);
            Console.WriteLine(WeekDays.Monday);
            Console.WriteLine(WeekDays.Tuesday);
            Console.WriteLine(WeekDays.Wednesday);
            Console.WriteLine(WeekDays.Thursday);
            Console.WriteLine(WeekDays.Friday);
            Console.WriteLine(WeekDays.Saturday);
            Console.Read();
        }
    }
}
