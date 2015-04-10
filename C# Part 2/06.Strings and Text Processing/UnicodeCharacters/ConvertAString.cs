namespace UnicodeCharacters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

/*Problem 10. Unicode characters

Write a program that converts a string to a sequence of C# Unicode character literals.
Use format strings.*/

    class ConvertAString
    {
        static void Main()
        {
            Console.Write("Please enter your word: ");
            string word = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {
                Console.Write("\\u00{0:X}", (int)word[i]);
            }
            Console.WriteLine();
        }
    }
}
