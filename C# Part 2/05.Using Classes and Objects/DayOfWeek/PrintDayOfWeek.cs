/*
Problem 3. Day of week

Write a program that prints to the console which day of the week is today.
Use System.DateTime.
*/

using System;
using System.Linq;

class PrintDayOfWeek
{
    static void Main()
    {
        DateTime dayNow = DateTime.Now;
        Console.WriteLine("Today is {0}", dayNow.DayOfWeek);
    }
}

