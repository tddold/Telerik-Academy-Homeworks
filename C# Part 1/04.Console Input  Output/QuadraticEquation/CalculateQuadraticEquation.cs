/*
Problem 6. Quadratic Equation

Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
*/

using System;
using System.Globalization;
using System.Threading;

class CalculateQuadraticEquation
{
    private static double FirstCoefficient()
    {
        double firstCoefficient;
        bool parseSuccessFirstCoefficient = true;

        do
        {
            Console.Write("Please enter the coefficient A of your quadratic equation: ");
            string value = Console.ReadLine();
            parseSuccessFirstCoefficient = Double.TryParse(value, out firstCoefficient);
        }
        while (parseSuccessFirstCoefficient == false);
        return firstCoefficient;
    }

    private static double SecondCoefficient()
    {
        double secondCoefficient;
        bool parseSuccessSecondCoefficient = true;

        do
        {
            Console.Write("Please enter the coefficient B of your quadratic equation: ");
            string value = Console.ReadLine();
            parseSuccessSecondCoefficient = Double.TryParse(value, out secondCoefficient);
        }
        while (parseSuccessSecondCoefficient == false);
        return secondCoefficient;
    }

    private static double ThirdCoefficient()
    {
        double thirdCoefficient;
        bool parseSuccessThirdCoefficient = true;

        do
        {
            Console.Write("Please enter the coefficient C of your quadratic equation: ");
            string value = Console.ReadLine();
            parseSuccessThirdCoefficient = Double.TryParse(value, out thirdCoefficient);
        }
        while (parseSuccessThirdCoefficient == false);
        return thirdCoefficient;
    }

    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        double firstCoefficient = FirstCoefficient();

        double secondCoefficient = SecondCoefficient();

        double thirdCoefficient = ThirdCoefficient();

            double discriminant = secondCoefficient * secondCoefficient - 4 * firstCoefficient * thirdCoefficient;
            double rootOne;
            double rootTwo;

            if (discriminant == 0)
            {
                rootOne = (-secondCoefficient - Math.Sqrt(discriminant)) / (2 * firstCoefficient);
                rootTwo = (-secondCoefficient + Math.Sqrt(discriminant)) / (2 * firstCoefficient);

                Console.WriteLine("You have two real equal roots: {0} and {1}", rootOne, rootTwo);
            }
            else if (discriminant > 0)
            {
                rootOne = (-secondCoefficient - Math.Sqrt(discriminant)) / (2 * firstCoefficient);
                rootTwo = (-secondCoefficient + Math.Sqrt(discriminant)) / (2 * firstCoefficient);


                Console.WriteLine("You have two real differents roots: {0} and {1}", rootOne, rootTwo);
            }
            else
            {
                rootOne = (-secondCoefficient - Math.Sqrt(discriminant)) / (2 * firstCoefficient);
                rootTwo = (-secondCoefficient + Math.Sqrt(discriminant)) / (2 * firstCoefficient);

                Console.WriteLine("There isn't roots in real numbers.");
            }
    }
}

