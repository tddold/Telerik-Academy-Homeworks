/*
Problem 2. Gravitation on the Moon

The gravitational field of the Moon is approximately 17% of that on the Earth.
Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
*/

using System;
using System.Threading;
using System.Globalization;

class WeightOnTheMoon
{
        const double percent = 0.17;
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Please enter you current weight: ");

        string input = Console.ReadLine();
        double weight;

        bool currentWeight = Double.TryParse(input, out weight);

        if (currentWeight == true)
        {
            double result = weight * percent;
            Console.WriteLine("Your weight on the Moon is: {0}", result);
        }
        else
        {
            Console.WriteLine("Invalid number!");
        }
    }
    
}
