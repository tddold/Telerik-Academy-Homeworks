namespace FurnitureManufacturer.Models
{
    using System;
    using System.Text;

    using Interfaces;

    public class Chair : Furniture, IChair, IFurniture
    {
        private const string NumberOfLegsArgumentOutOfRangeErrorMessage = "The number of legs cannot be less than 0.";
        private const string ChairToStringFormat = ", Legs: {0}";
        private const int NumberOfLegsMinimumValue = 0;

        private int numberOfLegs;

        public Chair(string setModel, MaterialType setMaterial, decimal setPrice, decimal setHeight, int setNumberOfLegs)
            : base(setModel, setMaterial, setPrice, setHeight)
        {
            this.NumberOfLegs = setNumberOfLegs;
        }

        public int NumberOfLegs
        {
            get
            {
                return this.numberOfLegs;
            }

            private set
            {
                if (value < NumberOfLegsMinimumValue)
                {
                    throw new ArgumentOutOfRangeException(NumberOfLegsArgumentOutOfRangeErrorMessage);
                }

                this.numberOfLegs = value;
            }
        }

        public override string ToString()
        {
            StringBuilder chairToString = new StringBuilder(base.ToString());

            chairToString.Append(ChairToStringFormat);

            return string.Format(chairToString.ToString(), this.NumberOfLegs);
        }
    }
}
