/*
Problem 3. Circle Perimeter and Area

Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.
*/

using System;
using System.Globalization;
using System.Threading;

class CalculatePerimeterAndAreaOfCircle
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        double radius;
        bool parseSuccessRadius = true;

        do
        {
            Console.Write("Please enter the radius of your circle: ");
            string value = Console.ReadLine();
            parseSuccessRadius = Double.TryParse(value, out radius);
        }
        while (parseSuccessRadius == false);

        double area = Math.PI * radius * radius;
        double perimeter = 2 * Math.PI * radius;

        Console.WriteLine("The perimeter of your circle is: {0:F2}", perimeter);
        Console.WriteLine("The area of your circle is: {0:F2}", area);
    }
}

