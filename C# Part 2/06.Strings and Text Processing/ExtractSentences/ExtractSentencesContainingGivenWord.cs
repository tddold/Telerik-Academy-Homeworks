namespace ExtractSentences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

/*Problem 8. Extract sentences

Write a program that extracts from a given text all sentences containing given word.
Example:

The word is: in

The text is: We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.

Consider that the sentences are separated by . and the words – by non-letter symbols.*/
    class ExtractSentencesContainingGivenWord
    {
        static void Main()
        {
            //Console.Write("Enter your text: ");
            //string text = Console.ReadLine();
            string text = @"We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. 
                            So we are drinking all the day. We will move out of it in 5 days.";

            string regex = @"\s*(?<sentence>[^\.]*?\bin\b(.|\s)*?\.)"; // If you want to use your own text and word you need to 
                                                                       // change the word "in" in the regex example

            MatchCollection result = Regex.Matches(text, regex); 

            Console.WriteLine(new string('-', 50));
            Console.WriteLine("All sentences containing \"in\": ");
            foreach (var item in result)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            Console.WriteLine(new string('-', 50));
        }
    }
}
