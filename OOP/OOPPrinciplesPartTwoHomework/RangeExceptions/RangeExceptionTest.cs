namespace RangeExceptions
{
    using System;

    // Problem 3. Range Exceptions

    // Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range. 
    // It should hold error message and a range definition [start … end].
    // Write a sample application that demonstrates the InvalidRangeException<int> and InvalidRangeException<DateTime> by 
    // entering numbers in the range [1..100] and dates in the range [1.1.1980 … 31.12.2013].
    public class RangeExceptionTest
    {
        public static void Main()
        {
            // Testing the InvalidRangeException with int
            try
            {
                throw new InvalidRangeException<int>(0, 100);
            }
            catch (Exception message)
            {
                Console.WriteLine(message.Message);
            }

            // Testing the InvalidRangeException with DateTime
            try
            {
                throw new InvalidRangeException<DateTime>(new DateTime(1980, 1, 1), new DateTime(2013, 12, 31));
            }
            catch (Exception message)
            {
                Console.WriteLine(message.Message);
            }
        }
    }
}
