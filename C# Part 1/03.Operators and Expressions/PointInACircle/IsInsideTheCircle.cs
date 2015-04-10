/*
Problem 7. Point in a Circle

Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).
*/

using System;
using System.Globalization;
using System.Threading;

class IsInsideTheCircle
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Please enter the coordinates of your point.");

        double numberX;
        bool parseSuccessX = true;

        do
        {
            Console.Write("Enter x: ");
            string value = Console.ReadLine();
            parseSuccessX = Double.TryParse(value, out numberX);
        }
        while (parseSuccessX == false);

        double numberY;
        bool parseSuccessY = true;

        do
        {
            Console.Write("Enter y: ");
            string value = Console.ReadLine();
            parseSuccessY = Double.TryParse(value, out numberY);
        }
        while (parseSuccessY == false);

        bool isInside = ((numberX * numberX) + (numberY * numberY)) <= 4;
        Console.WriteLine("The point (x, y) is inside a circle K([0, 0], 2). - {0}", isInside);
    }
}

