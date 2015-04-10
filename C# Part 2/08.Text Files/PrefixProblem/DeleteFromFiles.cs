/*Problem 11. Prefix "test"

Write a program that deletes from a text file all words that start with the prefix test.
Words contain only the symbols 0…9, a…z, A…Z, _.*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PrefixProblem
{
    class DeleteFromFiles
    {
        static void Main()
        {
            using (StreamWriter sw = new StreamWriter("output.txt"))
            {
                using (StreamReader sr = new StreamReader(@"..\..\..\deleteWords.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        line = line.ToLower();
                        line = Regex.Replace(line, @"\btest\w*\b", string.Empty);
                        sw.WriteLine(line);
                    }
                }
            }
            Console.WriteLine("The result is located in output.txt");
        }
    }
}
