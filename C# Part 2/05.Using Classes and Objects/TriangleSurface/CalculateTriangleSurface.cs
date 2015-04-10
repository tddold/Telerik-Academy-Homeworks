/*
Problem 4. Triangle surface

Write methods that calculate the surface of a triangle by given:
Side and an altitude to it;
Three sides;
Two sides and an angle between them;
Use System.Math
*/

using System;

class CalculateTriangleSurface
{
    static void SelectOption(int choise)
    {
        if (choise == 1)
        {
            Console.Write("Enter side: ");
            double side = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter altitude: ");
            double altitude = double.Parse(Console.ReadLine());

            CalculateByGivenSideAndAltitude(side, altitude);
        }
        else if (choise == 2)
        {
            Console.Write("Enter side A: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Enter side B: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Enter side C: ");
            double c = double.Parse(Console.ReadLine());

            CalculateByGivenThreeSides(a, b, c);
        }
        else if (choise == 3)
        {
            Console.Write("Enter side A: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Enter side B: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Enter side angle: ");
            double angle = double.Parse(Console.ReadLine());

            CalculateByGivenTwoSideAndAngle(a, b, angle);
        }
        else
        {
            Console.WriteLine("Invalid number. Please try again!");
        }
    }

    static void CalculateByGivenSideAndAltitude(double side, double altitude)
    {
        double surface = (side * altitude) / 2;
        Console.WriteLine("The surface of your triangle is {0:F3}", surface);
    }

    static void CalculateByGivenThreeSides(double a, double b, double c)
    {
        double perimeter = (a + b + c) / 2.0;
        double surface = Math.Sqrt(perimeter * (perimeter - a) * (perimeter - b) * (perimeter - c));
        Console.WriteLine("The surface of your triangle is {0:F3}", surface);
    }

    static void CalculateByGivenTwoSideAndAngle(double a, double b, double angle)
    {
        double surface = Math.Abs((a * b * Math.Sin(angle)) / 2);
        Console.WriteLine("The surface of your triangle is {0:F3}", surface);
    }
    static void Main()
    {
        Console.Write(@"How you want to calculate the triangle surface?
1. By given side and an altitude to it.
2. By given three sides.
3. By given Two sides and an angle between them.
Please enter your choice (1, 2 or 3): ");

        int choise = int.Parse(Console.ReadLine());
        SelectOption(choise);
    }
}

