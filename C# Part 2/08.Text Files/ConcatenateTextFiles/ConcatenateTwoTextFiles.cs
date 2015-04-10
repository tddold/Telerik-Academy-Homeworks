/*Problem 2. Concatenate text files

Write a program that concatenates two text files into another text file.*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcatenateTextFiles
{
    class ConcatenateTwoTextFiles
    {
        static void Main()
        {
            StreamReader firstFileReader = new StreamReader(@"..\..\..\test.txt", Encoding.ASCII);
            StreamReader secondFilerReader = new StreamReader(@"..\..\ConcatenateTwoTextFiles.cs", Encoding.ASCII);
            StreamWriter streamWriter = new StreamWriter("target.txt", true);

            using (streamWriter)
            {
                using (firstFileReader)
                {
                    Console.WriteLine("First file content is stored in target.txt");
                    string line = firstFileReader.ReadLine();
                    while (line != null)
                    {
                        streamWriter.WriteLine(line);
                        line = firstFileReader.ReadLine();
                    }

                }
                streamWriter.WriteLine(new string('-', 20));
                using (secondFilerReader)
                {
                    Console.WriteLine("Second file content is stored in target.txt");
                    string line = secondFilerReader.ReadLine();
                    while (line != null)
                    {
                        streamWriter.WriteLine(line);
                        line = secondFilerReader.ReadLine();
                    }
                }
                Console.WriteLine("Target.txt file content is filled with data");
            }
        }
    }
}
