using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 Problem 1. Square root

Write a program that reads an integer number and calculates and prints its square root.
If the number is invalid or negative, print Invalid number.
In all cases finally print Good bye.
Use try-catch-finally block.
 
 */
namespace SquareRoot
{
    class CalculateSquareRoot
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Please enter your number: ");
                uint number = uint.Parse(Console.ReadLine());
                double result = Math.Sqrt(number);
                Console.WriteLine("The square root of your number is {0}", result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Your number is not valid.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Your number is negative.");
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }
        }
    }
}
