namespace OrderWords
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

/*
Problem 24. Order words

Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.*/

    class PrintInAlphabeticalOrder
    {
        static void Main()
        {
            Console.Write("Please enter your words: ");

            string[] words = Console.ReadLine().Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);

            var sortedWords = words.OrderBy(x => x);

            foreach (var word in sortedWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}
