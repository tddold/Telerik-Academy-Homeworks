/*
Problem 9. Trapezoids

Write an expression that calculates trapezoid's area by given sides a and b and height h.
*/

using System;
using System.Globalization;
using System.Threading;

class CalculateAreaOfTrapezoid
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        double sideA;
        bool parseSuccessA = true;
        do
        {
            Console.Write("Please enter a number for side \"a\": ");
            string value = Console.ReadLine();
            parseSuccessA = Double.TryParse(value, out sideA);
        }
        while (parseSuccessA == false);

        double sideB;
        bool parseSuccessB = true;
        do
        {
            Console.Write("Please enter a number for side \"b\": ");
            string value = Console.ReadLine();
            parseSuccessB = Double.TryParse(value, out sideB);
        }
        while (parseSuccessB == false);

        double height;
        bool parseSuccessHeight = true;
        do
        {
            Console.Write("Please enter a number for height: ");
            string value = Console.ReadLine();
            parseSuccessHeight = Double.TryParse(value, out height);
        }
        while (parseSuccessHeight == false);

        double area = ((sideA + sideB) / 2) * height;

        Console.WriteLine("The area of your trapezoid is {0}", area);
    }
}

