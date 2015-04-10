namespace Point3D
{
    using System;
    using System.Collections.Generic;

    public class Path 
    {
        private List<Point3D> sequenceOfPoints;

        public Path()
        {
            this.sequenceOfPoints = new List<Point3D>();
        }

        public List<Point3D> SequenceOfPoints
        {
            get
            {
                return this.sequenceOfPoints;
            }
        }

        public void AddPath(Point3D path)
        {
            this.sequenceOfPoints.Add(path);
        }
    }
}
