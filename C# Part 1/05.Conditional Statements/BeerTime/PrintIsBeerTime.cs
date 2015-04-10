/*
Problem 10.* Beer Time

A beer time is after 1:00 PM and before 3:00 AM.
Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) 
and prints beer time or non-beer time according to the definition above or invalid time if the time cannot be parsed. 
Note: You may need to learn how to parse dates and times.
*/

using System;
using System.Globalization;

class PrintIsBeerTime
{
    static void Main()
    {
        DateTime start = DateTime.Parse("1:00 PM");
        DateTime end = DateTime.Parse("3:00 AM");
        Console.Write("Please enter time in format \"hh:mm tt\" (examples: 01:00 AM, 09:34 PM, 11:25 AM): ");

        string time = Console.ReadLine();

        try
        {
            DateTime newTime = DateTime.ParseExact(time, "h:mm tt", CultureInfo.InvariantCulture);

            if (newTime >= start || newTime < end)
            {
                Console.WriteLine("Beer time");
            }
            else
            {
                Console.WriteLine("Non-beer time");
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid time");
        }
    }
}

