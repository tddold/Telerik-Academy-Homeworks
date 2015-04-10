/*
Problem 1. Leap year

Write a program that reads a year from the console and checks whether it is a leap one.
Use System.DateTime.
*/

using System;

class CheckIsLeapYear
{
    static void Main()
    {
        Console.WriteLine("Please enter a year: ");

        int year;
        string value = Console.ReadLine();
        bool parseSuccess = int.TryParse(value, out year);

        while (parseSuccess == false || year < 1 || year > 9999)
        {
            Console.Write("Your year is invalid. Please try again: ");
            value = Console.ReadLine();
            parseSuccess = int.TryParse(value, out year);

        }

        Console.WriteLine("The year is leap: {0}", DateTime.IsLeapYear(year));
    }
}

