namespace SubStringInText
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

/*
Problem 4. Sub-string in text

Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
Example:

The target sub-string is "in"

The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

The result is: 9
*/
    class FindSubString
    {
        static void Main()
        {
            // Using regex

            Console.Write("The text is as follows: ");
            string text = Console.ReadLine();

            string regex = @"(?i)in"; // (?i) -> insensitive search of "in"

            MatchCollection result = Regex.Matches(text, regex); // Return a collection 

            int counter = 0;

            foreach (var item in result)
            {
                counter++;
            }

            Console.WriteLine(new string('-', 50));
            Console.WriteLine("How many times \"in\" is contained in a the text?");
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Answer: {0} times", counter);
            Console.WriteLine(new string('-', 50));

            // Using Substring

            //Console.Write("The text is as follows: ");
            //string text = Console.ReadLine();

            //Console.Write("The target sub-string is ");
            //string target = Console.ReadLine();
            //int counter = 0;

            //for (int i = 0; i <= text.Length - target.Length; i++)
            //{
            //    if (target == text.Substring(i, target.Length))
            //    {
            //        counter++;
            //    }
            //}

            //Console.WriteLine(new string('-', 50));
            //Console.WriteLine("The sub-string is contained {0} times", counter);
            //Console.WriteLine(new string('-', 50));
        }
    }
}
