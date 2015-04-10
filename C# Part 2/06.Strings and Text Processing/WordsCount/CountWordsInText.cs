namespace WordsCount
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

/*Problem 22. Words count

Write a program that reads a string from the console and lists all different words in the string along with information 
how many times each word is found.*/

    class CountWordsInText
    {
        static void Main()
        {
            //Console.Write("Please enter your sentences: ");
            //string text = Console.ReadLine();

            string text = @"Social Insurance applications for Canada use DMY format. " +
                           "Passport applications and tax returns use YYYY MM DD. " +
                           "Nearly all newspapers use MDY (MMM, D, YYYY). " +
                           "The default date format used by Microsoft Windows for English Canada is DD/MM/YYYY " +
                           "for all-numeric dates (short-date) and MMMM D, YYYY for long-dates; for French " +
                           "Canada it is YYYY-MM-DD for short-date and D MMMM YYYY for long-dates. ";

            string[] textSplit = text.Split(new char[] {' ', ',', '.', '(', ')', '-', '/', '\\', ';'}, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> countWords = new Dictionary<string, int>();

            foreach (var word in textSplit)
            {
                if (countWords.ContainsKey(word))
                {
                    countWords[word]++;
                }
                else
                {
                    countWords.Add(word, 1);
                }
            }

            foreach (var word in countWords)
            {
                Console.WriteLine("{0, 15} - {1} times", word.Key, word.Value);
            }
        }
    }
}
