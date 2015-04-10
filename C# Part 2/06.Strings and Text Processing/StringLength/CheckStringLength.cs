namespace StringLength
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

/*Problem 6. String length

Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, 
the rest of the characters should be filled with *. Print the result string into the console.*/
    class CheckStringLength
    {
        private const int maximumLength = 20;
        static void Main()
        {
            Console.Write("Please enter your string: ");
            string text = Console.ReadLine();

            StringBuilder newText = new StringBuilder();

            if (text.Length < 20)
            {
                newText.Append(text);

                for (int i = 0; i < maximumLength - text.Length; i++)
                {
                    newText.Append("*");
                }
                Console.WriteLine("Your string length was less than 20 characters -> {0}", newText);
            }
            else
            {
                Console.WriteLine("Your string length wasn't less than 20 characters -> {0}", text);
            }
        }
    }
}
