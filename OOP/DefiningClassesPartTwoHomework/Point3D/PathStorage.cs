namespace Point3D
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    public static class PathStorage
    {
        public static void SavePath(Path path)
        {
            StreamWriter savePath = new StreamWriter(@"..\..\PathSave.txt");
            StringBuilder result = new StringBuilder();

            foreach (var item in path.SequenceOfPoints)
            {
                result.Append(string.Format("{0} {1} {2}", item.X, item.Y, item.Z));
                result.Append(Environment.NewLine);
            }

            using (savePath)
            {
                savePath.WriteLine(result);
            }
        }

        public static void LoadPath()
        {
            StreamReader loadPath = new StreamReader(@"..\..\PathLoad.txt");
            Path currentPath = new Path();

            using (loadPath)
            {
                string line = loadPath.ReadLine();

                while (line != null)
                {
                    string[] coordinates = line.Split(' ');

                    Point3D newPoint = new Point3D(int.Parse(coordinates[0]), int.Parse(coordinates[1]), int.Parse(coordinates[2]));

                    currentPath.AddPath(newPoint);

                    line = loadPath.ReadLine();
                }
            }

            //foreach (var item in currentPath.sequenceOfPoints)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
