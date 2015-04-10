namespace Point3D
{
    using System;

    public class Test
    {
        public static void Main()
        {
            // Adding some paths to save in file
            Point3D path = new Point3D(1, 4, 7);
            Path current = new Path();

            current.AddPath(path);

            path = new Point3D(1, 74, 78);
            current.AddPath(path);

            path = new Point3D(18, 14, 8);
            current.AddPath(path);

            path = new Point3D(100, 84, 47);
            current.AddPath(path);

            path = new Point3D(47, 94, 0);
            current.AddPath(path);

            PathStorage.SavePath(current);

            Console.WriteLine("The paths are saved in PathSave.txt");

            // Uncomment the foreach cycle in PathStorage.cs to print the path readed from PathLoad.txt
            PathStorage.LoadPath();
        }
    }
}
