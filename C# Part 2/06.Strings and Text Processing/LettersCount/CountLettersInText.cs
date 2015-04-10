namespace LettersCount
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

/*Problem 21. Letters count

Write a program that reads a string from the console and prints all different letters in the string along with 
information how many times each letter is found.*/
    class CountLettersInText
    {
        static void Main()
        {
            Console.Write("Please enter your sentences: ");
            string text = Console.ReadLine();

            //string text = @"Social Insurance applications for Canada use DMY format.<p>" +
            //              "Passport applications and tax returns use YYYY MM DD. <p>" +
            //              "Nearly all newspapers use MDY (MMM, D, YYYY). <p>" + 
            //              "The default date format used by Microsoft Windows for English Canada is DD/MM/YYYY" +
            //              "for all-numeric dates (short-date) and MMMM D, YYYY for long-dates; for French" +
            //              "Canada it is YYYY-MM-DD for short-date and D MMMM YYYY for long-dates.";
            //

            char[] letters = new char[255];

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsLetter(text[i]))
                {
                    letters[text[i]]++;
                }
            }

            for (int i = 0; i < letters.Length; i++)
            {
                if (char.IsLetter((char)i) && letters[i] > 0)
                {
                    Console.WriteLine("'{0}' - {1} times", (char)i, (int)letters[i]);
                }
            }
        }
    }
}
