/*Problem 7. Replace sub-string

Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
Ensure it will work with large files (e.g. 100 MB).*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceSubstring
{
    class ReplacesAllOccurrences
    {
        static void Main()
        {
            using (StreamWriter sw = new StreamWriter("output.txt"))
            {
                using (StreamReader sr = new StreamReader(@"..\..\..\someBooks.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        line = line.ToLower();
                        line = line.Replace("start", "finish");
                        sw.WriteLine(line);
                    }
                }
                Console.WriteLine("Your file is located in output.txt");
            }
        }
    }
}
