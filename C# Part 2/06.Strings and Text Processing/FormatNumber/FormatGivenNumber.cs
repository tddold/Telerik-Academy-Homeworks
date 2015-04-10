namespace FormatNumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

/*Problem 11. Format number

Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
Format the output aligned right in 15 symbols.*/
    class FormatGivenNumber
    {
        static void Main()
        {
            Console.Write("Please enter an integer: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("The number as hexadecimal number: {0}", number.ToString("X")); // or {0:X}
            Console.WriteLine("The number as percentage: {0}", number.ToString("P3")); // or {0:P3}
            Console.WriteLine("The number in scientific notation: {0}", number.ToString("E")); // or {0:E}
            Console.WriteLine("The number as a decimal number: {0}", number.ToString("D")); // or {0:D}
        }
    }
}
