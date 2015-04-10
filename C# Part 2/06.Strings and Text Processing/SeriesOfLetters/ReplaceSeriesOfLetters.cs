namespace SeriesOfLetters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

/*Problem 23. Series of letters

Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
Example:

input	                        output
aaaaabbbbbcdddeeeedssaa	        abcdedsa*/
    class ReplaceSeriesOfLetters
    {
        static void Main()
        {
            Console.WriteLine("Please enter your string: ");
            string text = Console.ReadLine();

            string sequenceLetter = string.Empty;

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < text.Length - 1; i++)
            {
                sequenceLetter = text[i].ToString();

                if (text[i] != text[i + 1])
                {
                    result.Append(sequenceLetter);
                }
            }
            result.Append(text[text.Length - 1]);
            Console.WriteLine("The result is {0}", result);
        }
    }
}
