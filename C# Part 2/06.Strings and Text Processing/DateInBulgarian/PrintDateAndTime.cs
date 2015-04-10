namespace DateInBulgarian
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Globalization;

/*Problem 17. Date in Bulgarian

Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints the date and time after 
6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.*/

    class PrintDateAndTime
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.Write("Please enter date and time in format - DAY.MONTH.YEAR HOUR:MINUTE:SECOND -> ");

            string[] dateAndTime = Console.ReadLine().Split(new char[] { ' ', '.', ',', '/', ':' }, StringSplitOptions.RemoveEmptyEntries);

            int day = int.Parse(dateAndTime[0]);
            int month = int.Parse(dateAndTime[1]);
            int year = int.Parse(dateAndTime[2]);
            int hour = int.Parse(dateAndTime[3]);
            int minute = int.Parse(dateAndTime[4]);
            int second = int.Parse(dateAndTime[5]);

            DateTime dateInBulgaria = new DateTime(year, month, day, hour, minute, second);
            Console.WriteLine("The date and time after 6 hours and 30 minutes: {0}", dateInBulgaria.AddHours(6).AddMinutes(30));
            var culture = new CultureInfo("bg-BG");
            var dayOfWeek = culture.DateTimeFormat.GetDayName(dateInBulgaria.AddHours(6).AddMinutes(30).DayOfWeek);
            Console.WriteLine("The day of the week in bulgarian is \"{0}\"", dayOfWeek);
        }
    }
}
