namespace Shapes
{
    using System;

    public abstract class Shape
    {
        private const string ArgumentWidthExceptionMsg = "The width must be a positive number bigger than 0";
        private const string ArgumentHeightExceptionMsg = "The height must be a positive number bigger than 0";

        private double width;
        private double height;

        protected Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        protected double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ArgumentWidthExceptionMsg);
                }
                else
                {
                    this.width = value;
                }
            }
        }

        protected double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ArgumentHeightExceptionMsg);
                }
                else
                {
                    this.height = value;
                }
            }
        }

        public abstract double CalculateSurface();
    }
}
