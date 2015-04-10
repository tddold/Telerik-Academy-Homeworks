/*Problem 13. Count words

Write a program that reads a list of words from the file words.txt and finds how many times each of the words is contained in another file test.txt.
The result should be written in the file result.txt and the words should be sorted by the number of their occurrences in descending order.
Handle all possible exceptions in your methods.*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CountWords
{
    class CountGivenWords
    {
        static void Main()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("result.txt"))
                {
                    using (StreamReader sr = new StreamReader(@"..\..\..\test.txt"))
                    {
                        string line;
                        string[] words = File.ReadAllLines(@"..\..\..\words.txt");
                        int[] values = new int[words.Length];

                        while ((line = sr.ReadLine()) != null)
                        {
                            line = line.ToLower();
                            for (int i = 0; i < words.Length; i++)
                            {
                                values[i] += Regex.Matches(line, @"\b" + words[i] + @"\b").Count;
                            }
                        }
                        Array.Sort(values, words);
                        for (int i = words.Length - 1; i >= 0; i--)
                        {
                            sw.WriteLine("{0}: {1}", words[i], values[i]);
                        }
                    }
                }
            }
            catch (FieldAccessException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
