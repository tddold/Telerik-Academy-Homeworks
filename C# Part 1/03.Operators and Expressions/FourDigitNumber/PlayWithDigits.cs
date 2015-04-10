/*
Problem 6. Four-Digit Number

Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
Prints on the console the number in reversed order: dcba (in our example 1102).
Puts the last digit in the first position: dabc (in our example 1201).
Exchanges the second and the third digits: acbd (in our example 2101).
The number has always exactly 4 digits and cannot start with 0.
*/

using System;

class PlayWithDigits
{
    static void Main()
    {
        bool parseSuccess = true;
        int abcd;
        int sum = 0;

        do
        {
            Console.Write("Please enter a four-digit number between 1000 and 9999: ");
            string number = Console.ReadLine();

            parseSuccess = Int32.TryParse(number, out abcd);
        }
        while (parseSuccess == false || abcd < 1000 || abcd > 9999);

        Console.WriteLine();

        int d = abcd % 10;
        int c = (abcd / 10) % 10;
        int b = (abcd / 100) % 10;
        int a = abcd / 1000;

        sum = a + b + c + d;
        Console.WriteLine("The sum of the digits is: {0}", sum);

        Console.WriteLine("The number in reversed order: {0}{1}{2}{3}", d, c, b, a);
        Console.WriteLine("Puts the last digit in the first position: {0}{1}{2}{3}", d, a, b, c);
        Console.WriteLine("Exchanges the second and the third digits: {0}{1}{2}{3}", a, c, b, d);
    }
}

