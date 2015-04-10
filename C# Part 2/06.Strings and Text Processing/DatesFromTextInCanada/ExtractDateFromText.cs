namespace DatesFromTextInCanada
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Threading;
    using System.Threading.Tasks;

/*Problem 19. Dates from text in Canada

Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
Display them in the standard date format for Canada.*/

    class ExtractDateFromText
    {
        static void Main()
        {
            string text = @"Some text: Presley was born on 08.01.1935, in Tupelo, Mississippi.Jensen predicted that Halley's" +
                            "Comet would be pulled into Earth's orbit on 29.04.1987, causing widespread destruction." +
                            "End of the word wasn't on 21/12/12. Camping predicted the Rapture would occur on September 6, 1994." +
                            "Ivet lalova was born on 18/05/1989 in Sofia. On 19.06.2004 in Plovdiv, Lalova tied Irina Privalova as the" +
                            "sixth fastest woman in 100 metres history, recording a time of 10.77 seconds.";

            string regex = @"(0[1-9]|1[0-9]|2[0-9]|3[0-1])\.(0[1-9]|1[0-2])\.([0-9][0-9][0-9][0-9])";

            MatchCollection dateCollection = Regex.Matches(text, regex);

            Console.WriteLine(text);
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("All dates in format DD.MM.YYYY:");
            foreach (var date in dateCollection)
            {
                Console.WriteLine(date);
            }
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("The dates in the standard date format for Canada:");

            var cultureInfo = new CultureInfo("en-CA");
            foreach (var date in dateCollection)
            {
                DateTime checkDate = DateTime.ParseExact(date.ToString(), "d.M.yyyy", cultureInfo);
                Console.WriteLine("{0:d.M.yyyy}", checkDate);
            }
        }
    }
}
