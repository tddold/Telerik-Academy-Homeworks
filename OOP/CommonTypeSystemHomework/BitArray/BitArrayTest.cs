namespace BitArray
{
    using System;

    // Problem 5. 64 Bit array

    // Define a class BitArray64 to hold 64 bit values inside an ulong value.
    // Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.
    public class BitArrayTest
    {
        public static void Main()
        {
            BitArray64 firstArray = new BitArray64(150);
            Console.WriteLine(firstArray);

            Console.WriteLine();

            BitArray64 secondArray = new BitArray64(150);
            Console.WriteLine(secondArray);

            // Check are they equal
            Console.WriteLine("Are they equal: {0}\n", firstArray.Equals(secondArray));

            // Change element
            secondArray[50] = 1;
            Console.WriteLine(firstArray);

            Console.WriteLine();

            Console.WriteLine(secondArray);

            Console.WriteLine("Are they equal: {0}\n", firstArray.Equals(secondArray));

            // Get HashCode
            Console.WriteLine("HashCode: {0}", firstArray.GetHashCode());
            Console.WriteLine("HashCode: {0}", secondArray.GetHashCode());
        }
    }
}
