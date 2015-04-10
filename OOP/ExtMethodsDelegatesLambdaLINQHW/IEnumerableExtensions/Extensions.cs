namespace IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    // Problem 2. IEnumerable extensions
    // Implement a set of extension methods for IEnumerable<T> 
    // that implement the following group functions: sum, product, min, max, average.
    public static class Extensions
    {
        public static string Sum<T>(this IEnumerable<T> input) where T : struct
        {
            dynamic sum = default(T);

            foreach (T item in input)
            {
                sum += item;
            }

            return sum.ToString();
        }

        public static string Product<T>(this IEnumerable<T> input) where T : struct
        {
            dynamic product = 1;

            foreach (var item in input)
            {
                product *= item;
            }

            return product.ToString();
        }

        public static T Min<T>(this IEnumerable<T> input) where T : struct, IComparable, IComparable<T>, IConvertible, IEquatable<T>, IFormattable
        {
            T min = input.First();

            foreach (var item in input)
            {
                if (min.CompareTo(item) == 1)
                {
                    min = item;
                }
            }

            return min;
        }

        public static T Max<T>(this IEnumerable<T> input) where T : struct, IComparable, IComparable<T>, IConvertible, IEquatable<T>, IFormattable
        {
            T max = input.First();

            foreach (var item in input)
            {
                if (max.CompareTo(item) == -1)
                {
                    max = item;
                }
            }

            return max;
        }

        public static T Average<T>(this IEnumerable<T> input) where T : struct, IComparable, IComparable<T>, IConvertible, IEquatable<T>, IFormattable
        {
            int counter = 0;
            dynamic sum = default(T);
            
            foreach (T item in input)
            {
                sum += item;
                counter++;
            }

            return sum / counter;
        }
    }
}
