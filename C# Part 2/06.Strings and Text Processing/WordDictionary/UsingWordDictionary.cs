namespace WordDictionary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /*Problem 14. Word dictionary

    A dictionary is stored as a sequence of text lines containing words and their explanations.
    Write a program that enters a word and translates it by using the dictionary.
    Sample dictionary:

    input	            output
    .NET ----------->	platform for applications from Microsoft
    CLR	managed ---->   execution environment for .NET
    namespace ------>	hierarchical organization of classes*/
    class UsingWordDictionary
    {
        static void Main()
        {
            string dictionary = ".NET - platform for applications from Microsoft\nCLR - managed execution environment for .NET\nnamespace - hierarchical organization of classes";

            string[] text = dictionary.ToLower().Split(new char[] { '\n', '-', });

            Console.Write("Please enter your word: ");
            string word = Console.ReadLine().ToLower();

            bool contain = false;
            for (int i = 0; i < text.Length; i++)
            {
                if (word + " " == text[i])
                {
                    Console.WriteLine("{0} - {1}", word, text[i + 1]);
                    contain = true;
                }
            }

            if (contain == false)
            {
                Console.WriteLine("I cant find your word in the dictionary.");
            }

        }
    }
}
