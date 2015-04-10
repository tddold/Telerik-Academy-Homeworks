/*Problem 6. Save sorted names

Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveSortedNames
{
    class SortNames
    {
        static void Main()
        {
            StreamReader reader = new StreamReader(@"..\..\..\names.txt", Encoding.ASCII);
            StreamWriter writer = new StreamWriter("sorted.txt", true);

            using (writer)
            {
                using (reader)
                {
                    string line = reader.ReadLine();
                    List<string> Names = new List<string>();
                    Names.Add(line);

                    while (line != null)
                    {
                        line = reader.ReadLine();
                        if (line == null)
                        {
                            break;
                        }
                        Names.Add(line);
                    }

                    Console.WriteLine("Strings from file:");

                    foreach (string name in Names)
                    {
                        Console.WriteLine(name + " ");
                    }

                    Console.WriteLine();
                    Names.Sort();
                    Console.WriteLine("Names will now be sortred in sortred.txt:");

                    foreach (string name in Names)
                    {
                        writer.WriteLine(name);
                    }
                }
            }
        }
    }
}
