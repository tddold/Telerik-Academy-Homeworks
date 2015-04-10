namespace ExtensionMethodSubstring
{
    using System;
    using System.Text;

    // Problem 1. StringBuilder.Substring/
    // Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder 
    // and has the same functionality as Substring in the class String.
    public static class Extensions
    {
       public static StringBuilder Substring(this StringBuilder input, int index, int length)
        {
           if (index < 0 || index >= input.Length || index + length >= input.Length)
           {
               throw new IndexOutOfRangeException();
           }
           else
           {
               StringBuilder result = new StringBuilder();

               for (int i = index; i < index + length; i++)
               {
                   result.Append(input[i]);
               }

               return result;
           }
        }
    }
}
