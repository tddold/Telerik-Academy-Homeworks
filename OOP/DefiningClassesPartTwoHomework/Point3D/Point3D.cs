namespace Point3D
{
    public struct Point3D
    {
        private static readonly Point3D StartOfCoordinateSystem;

        static Point3D()
        {
            StartOfCoordinateSystem = new Point3D(0, 0, 0);
        }

        public Point3D(int x, int y, int z)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public int X { get; set; }

        public int Y { get; set; }

        public int Z { get; set; }

        public Point3D Start
        {
            get
            {
                return StartOfCoordinateSystem;
            }
        }

        public override string ToString()
        {
            return string.Format("Point {0}, {1}, {2}", this.X, this.Y, this.Z);
        }
    }
}
