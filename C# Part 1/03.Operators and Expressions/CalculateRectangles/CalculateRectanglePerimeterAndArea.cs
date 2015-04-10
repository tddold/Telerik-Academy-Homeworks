/*
Problem 4. Rectangles

Write an expression that calculates rectangle’s perimeter and area by given width and height.
*/

using System;
using System.Threading;
using System.Globalization;

class CalculateRectanglePerimeterAndArea
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Please enter the widht of you rectangle: ");

        string valueOne = Console.ReadLine();
        double widht;
        bool parseSuccessOne = Double.TryParse(valueOne, out widht);

        Console.Write("Please enter the height of you rectangle: ");

        string valueTwo = Console.ReadLine();
        double height;
        bool parseSuccessTwo = Double.TryParse(valueTwo, out height);

        if (parseSuccessOne == true && parseSuccessTwo == true)
        {
            double perimeter = 2 * widht + 2 * height;
            double area = widht * height;

            Console.WriteLine("The perimeter of your rectangle is {0}", perimeter);
            Console.WriteLine("The area of your rectangle is {0}", area);
        }
        else
        {
            Console.WriteLine("Invalid data");
        }

    }
}

