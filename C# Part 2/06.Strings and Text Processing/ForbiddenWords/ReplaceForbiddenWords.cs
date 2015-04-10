namespace ForbiddenWords
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

/*Problem 9. Forbidden words

We are given a string containing a list of forbidden words and a text containing some of these words.
Write a program that replaces the forbidden words with asterisks.
Example text: Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and 
is implemented as a dynamic language in CLR.

Forbidden words: PHP, CLR, Microsoft

The expected result: ********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and 
is implemented as a dynamic language in ***.*/

    class ReplaceForbiddenWords
    {
        static void Main()
        {
            string text = @"Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and " + 
                            "is implemented as a dynamic language in CLR.";

            string regex = @"\S?\w*(PHP|CLR|Microsoft)";

            Console.WriteLine("The text before the change:");
            Console.WriteLine(new string('-', 50));
            Console.WriteLine(text);
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("The text after the change:");
            Console.WriteLine(new string('-', 50));
            Console.WriteLine(Regex.Replace(text, regex, m => new string('*', m.Length)));
            Console.WriteLine(new string('-', 50));
        }
    }
}
