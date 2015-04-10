namespace Shapes
{
    public class Square : Shape
    {
        public Square(double height)
            : base(height, height)
        {
        }

        public override double CalculateSurface()
        {
            return this.Width * this.Height;
        }
    }
}
