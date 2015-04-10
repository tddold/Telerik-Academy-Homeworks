namespace FurnitureManufacturer.Models
{
    using System;
    using System.Text;

    using FurnitureManufacturer.Interfaces;

    public class Table : Furniture, IFurniture, ITable
    {
        private const string LengthErrorMessage = "The length cannot be less or equal to 0.";
        private const string WidthErrorMessage = "The width cannot be less or equal to 0.";
        private const string TableToStringFormat = ", Length: {0}, Width: {1}, Area: {2}";
        private const decimal LengthMinimumValue = 0.00m;
        private const decimal WidthMinimumValue = 0.00m;

        private decimal length;
        private decimal width;

        public Table(string setModel, MaterialType setMaterial, decimal setPrice, decimal setHeight, decimal setLength, decimal setWidth)
            : base(setModel, setMaterial, setPrice, setHeight)
        {
            this.Length = setLength;
            this.Width = setWidth;
        }

        public decimal Length
        {
            get
            {
                return this.length;
            }

            private set
            {
                if (value <= LengthMinimumValue)
                {
                    throw new ArgumentOutOfRangeException(LengthErrorMessage);
                }

                this.length = value;
            }
        }

        public decimal Width
        {
            get
            {
                return this.width;
            }

            private set
            {
                if (value < WidthMinimumValue)
                {
                    throw new ArgumentOutOfRangeException(WidthErrorMessage);
                }

                this.width = value;
            }
        }

        public decimal Area
        {
            get
            {
                return this.Length * this.Width;
            }
        }

        public override string ToString()
        {
            StringBuilder tableToString = new StringBuilder(base.ToString());

            tableToString.Append(TableToStringFormat);

            return string.Format(tableToString.ToString(), this.Length, this.Width, this.Area);
        }
    }
}
