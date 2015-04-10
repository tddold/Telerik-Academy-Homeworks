/*Problem 9. Delete odd lines

Write a program that deletes from given text file all odd lines.
The result should be in the same file.*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteOddLines
{
    class DeleteAllOddLines
    {
        static void Main()
        {
            using (StreamWriter sw = new StreamWriter("output.txt"))
            {
                using (StreamReader sr = new StreamReader(@"..\..\..\test.txt"))
                {
                    string line;
                    int counter = 0;
                    while ((line = sr.ReadLine()) != null)
                    {
                        counter++;
                        if ((counter & 1) == 1)
                        {
                            sw.WriteLine(line);
                        }
                    }
                }
            }
            using (StreamWriter sw = new StreamWriter(@"..\..\..\test.txt"))
            {
                using (StreamReader sr = new StreamReader("output.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        sw.WriteLine(line);
                    }
                }
            }
        }
    }
}
