/*
Problem 5. Formatting Numbers

Write a program that reads 3 numbers:
integer a (0 <= a <= 500)
floating-point b
floating-point c
The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
The number a should be printed in hexadecimal, left aligned
Then the number a should be printed in binary form, padded with zeroes
The number b should be printed with 2 digits after the decimal point, right aligned
The number c should be printed with 3 digits after the decimal point, left aligned.
*/

using System;
using System.Globalization;
using System.Threading;

class Program
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int firstNumber;
        bool parseSuccessFirstNumber = true;

        do
        {
            Console.Write("Please enter a positive integer between 0 and 500: ");
            string value = Console.ReadLine();
            parseSuccessFirstNumber = Int32.TryParse(value, out firstNumber);
        }
        while (parseSuccessFirstNumber == false || firstNumber < 0 || firstNumber > 500);

        double secondNumber;
        bool parseSuccessSecondNumber = true;

        do
        {
            Console.Write("Please enter your first floating-point number: ");
            string value = Console.ReadLine();
            parseSuccessSecondNumber = Double.TryParse(value, out secondNumber);
        }
        while (parseSuccessSecondNumber == false);

        double thirdNumber;
        bool parseSuccessThirdNumber = true;

        do
        {
            Console.Write("Please enter your second floating-point number: ");
            string value = Console.ReadLine();
            parseSuccessThirdNumber = Double.TryParse(value, out thirdNumber);
        }
        while (parseSuccessThirdNumber == false);


        Console.WriteLine("|{0,-10:X}|{1}|{2,10:F2}|{3,-10:F3}|", firstNumber, Convert.ToString(firstNumber, 2).PadLeft(10, '0'), secondNumber, thirdNumber);
    }

}
