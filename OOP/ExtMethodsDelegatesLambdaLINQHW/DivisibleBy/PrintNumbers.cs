namespace DivisibleBy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    // Problem 6. Divisible by 7 and 3

    // Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. 
    // Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.
    public class PrintNumbers
    {
        public static void Print(IEnumerable<int> numbers)
        {
            foreach (var number in numbers)
            {
                Console.Write("{0} ", number);
            }

            Console.WriteLine();
        }

        public static void Main()
        {
            List<int> numbers = new List<int> { 7, 15, 2, 1, 18, 25, 27, 29, 16, 10, 11, 4, 5 };

            var numbersDivisibleBy = numbers.Where(n => n % 7 == 0 || n % 3 == 0);
            Console.Write("Using lambda expressions: ");
            Print(numbersDivisibleBy);

            var numbersDivisibleByLINQ =
                from number in numbers
                where (number % 7) == 0 || (number % 3 == 0)
                select number;

            Console.Write("Using LINQ: ");
            Print(numbersDivisibleByLINQ);
        }
    }
}
