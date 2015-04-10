namespace Palindromes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

/*Problem 20. Palindromes

Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.*/
    class ExtractPalindromes
    {
        static bool Reverse(string word)
        {
            return word.ToCharArray().SequenceEqual(word.ToCharArray().Reverse());
        }
        static void Main()
        {
            Console.Write("Please enter your text: ");
            string text = Console.ReadLine();

            string regex = @"\b\w+\b";

            MatchCollection result = Regex.Matches(text, regex);

            Console.Write("All palindromes: ");
            foreach (var item in result)
            {
                if (Reverse(item.ToString()))
                {
                    Console.Write("{0} ", item);
                }
            }
            Console.WriteLine();
            
        }
    }
}
