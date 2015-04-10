/*Problem 3. Line numbers

Write a program that reads a text file and inserts line numbers in front of each of its lines.
The result should be written to another text file.*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineNumbers
{
    class InsertLineNumbers
    {
        static void Main()
        {
            StreamReader reader = new StreamReader(@"..\..\..\test.txt", Encoding.ASCII);
            StreamWriter writer = new StreamWriter("target.txt", true);

            using (writer)
            {
                using (reader)
                {
                    string line = reader.ReadLine();
                    int counter = 0;
                    while (line != null)
                    {
                        counter++;
                        line = line.Insert(0, "Line " + counter.ToString() + ": ");
                        Console.WriteLine(line + " is being stored id target.txt");
                        writer.WriteLine(line);
                        line = reader.ReadLine();
                    }
                }

            }
        }
    }
}
