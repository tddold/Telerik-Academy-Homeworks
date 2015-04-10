/*
Problem 5. Workdays

Write a method that calculates the number of workdays between today and given date, passed as parameter.
Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.
*/


using System;
using System.Threading;
using System.Globalization;

class CalculateNumbersOfWorkdays
{
    static DateTime[] holidays =
    {
        new DateTime(2015, 03, 03),
        new DateTime(2015, 04, 10),
        new DateTime(2015, 04, 11),
        new DateTime(2015, 04, 12),
        new DateTime(2015, 04, 13),
        new DateTime(2015, 09, 22),
        new DateTime(2015, 12, 25),
        new DateTime(2015, 12, 31),
    };
    static void Main()
    {
        DateTime today = DateTime.Today;

        Console.WriteLine("Please enter a date in format YEAR/MONTH/DAY: ");

        string dateAsString = Console.ReadLine();

        DateTime date = DateTime.Parse(dateAsString);

        int counter = 0;
        int index = 0;
        for (int i = 0; i < (date - today).Days; i++)
        {
            today.AddDays(i);

            if (today.AddDays(i).DayOfWeek == DayOfWeek.Saturday || today.AddDays(i).DayOfWeek == DayOfWeek.Sunday)
            {
                continue;
            }
            else if (today.AddDays(i) == holidays[index])
            {
                index++;
                continue;
            }
            else
            {
                counter++;
            }
        }
        Console.WriteLine("They are {0} workdays from {1:dd.MM.yyyy} to {2:dd.MM.yyyy}", counter, today, date);

    }
}

