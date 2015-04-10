namespace DateDifference
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Globalization;

/*Problem 16. Date difference

Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.*/
    class CalculateNumberOfDays
    {
        static void Main()
        {
            Console.Write("Please enter your first date in format - Day.Month.Year: ");
            DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy", CultureInfo.InvariantCulture);

            Console.Write("Please enter your second date in format - Day.Month.Year: ");
            DateTime secondDate = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy", CultureInfo.InvariantCulture);

            while (secondDate < firstDate)
            {
                Console.Write("Your second date must be bigger than the first one. Try again: ");
                DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy", CultureInfo.InvariantCulture);
            }

            Console.WriteLine("Distance: {0} days.", (secondDate - firstDate).Days);
        }
    }
}
