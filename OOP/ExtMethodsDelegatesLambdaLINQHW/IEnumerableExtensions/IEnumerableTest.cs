namespace IEnumerableExtensions
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class IEnumerableTest
    {
        public static void Main()
        {
            var listOfnNumbers = new List<int>();

            listOfnNumbers.Add(15);
            listOfnNumbers.Add(10);
            listOfnNumbers.Add(5);
            listOfnNumbers.Add(7);
            listOfnNumbers.Add(9);

            string sum = listOfnNumbers.Sum();
            Console.WriteLine("Sum: {0}", sum);

            string product = listOfnNumbers.Product();
            Console.WriteLine("Product: {0}", product);

            var min = listOfnNumbers.Min();
            Console.WriteLine("Min: {0}", min);

            var max = listOfnNumbers.Max();
            Console.WriteLine("Max: {0}", max);

            var average = listOfnNumbers.Average();
            Console.WriteLine("Average: {0}", average);
        }
    }
}
