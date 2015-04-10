/*Problem 4. Compare text files

Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
Assume the files have equal number of lines.*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareTextFiles
{
    class CompareTwoTextFiles
    {
        static void Main()
        {
            StreamReader firstFile = new StreamReader(@"..\..\..\test.txt", Encoding.ASCII);
            StreamReader secondFIle = new StreamReader(@"..\..\..\testOther.txt", Encoding.ASCII);

            using (firstFile)
            {
                using (secondFIle)
                {
                    string firstFileContent = firstFile.ReadLine();
                    string secondFileCOntent = secondFIle.ReadLine();
                    int counter = 0;
                    while (firstFileContent != null && secondFileCOntent != null)
                    {
                        if (firstFileContent.CompareTo(secondFileCOntent) == 0)
                        {
                            counter++;
                        }
                        firstFileContent = firstFile.ReadLine();
                        secondFileCOntent = secondFIle.ReadLine();
                    }
                    Console.WriteLine("{0} lines are equal", counter);
                }
            }
        }
    }
}
