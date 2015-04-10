namespace MobileDevice
{
    using System;

    public class Display
    {
        // Declaring fields
        private int? sizeOfDisplay;
        private int? numberOfColors;

        // Declaring constructors
        public Display()
        {
        }

        public Display(int? setSize = null)
        {
            this.SizeOfDisplay = setSize;
        }

        public Display(int? setSize, int? setNumberOfColors = null)
            : this(setSize)
        {
            this.NumberOfColors = setNumberOfColors;
        }

        // Declaring properties
        public int? SizeOfDisplay
        {
            get
            {
                return this.sizeOfDisplay;
            }

            set
            {
                if (value <= 0)
                {
                    throw new InvalidOperationException("The screen can't be equal or smaller than 0");
                }
                else
                {
                    this.sizeOfDisplay = value;
                }
            }
        }

        public int? NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }

            set
            {
                if (value <= 0)
                {
                    throw new InvalidOperationException("The number of colors must be bigger than 0");
                }
                else
                {
                    this.numberOfColors = value;
                }
            }
        }
    }
}
