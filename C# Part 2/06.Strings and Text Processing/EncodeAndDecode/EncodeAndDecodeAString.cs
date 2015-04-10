namespace EncodeAndDecode
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

 /*Problem 7. Encode/decode

Write a program that encodes and decodes a string using given encryption key (cipher).
The key consists of a sequence of characters.
The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, 
the second – with the second, etc. When the last key character is reached, the next is the first.*/

    class EncodeAndDecodeAString
    {
        static void Main()
        {
            Console.Write("Please enter your string: ");
            string word = Console.ReadLine();

            Console.Write("Please enter your encryption key: ");
            string key = Console.ReadLine();

            StringBuilder encode = new StringBuilder();

            //Encoding
            for (int i = 0, j = 0; i < word.Length; i++, j++)
            {
                encode.Append((char)(word[i] ^ key[j]));

                if (j == key.Length - 1)
                {
                    j = 0;
                }
            }
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("The word after the encoding: {0} -> {1}", word, encode);

            StringBuilder decode = new StringBuilder();

            //Decoding
            for (int i = 0, j = 0; i < encode.Length; i++, j++)
            {
                decode.Append((char)(encode[i] ^ key[j]));

                if (j == key.Length - 1)
                {
                    j = 0;
                }
            }
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("The word after the decoding: {0} -> {1}",encode, decode);
            Console.WriteLine(new string('-', 50));
        }
    }
}
