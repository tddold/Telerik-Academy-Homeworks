namespace FurnitureManufacturer.Models
{
    using System;

    using FurnitureManufacturer.Interfaces;

    public abstract class Furniture : IFurniture
    {
        private const string ModelArgumentNullExceptionErrorMessage = "Model name cannot be empty or null.";
        private const string ModelArgumentOutOfRangeExceptionErrorMessage = "Model name cannot be with less than 3 symbols.";
        private const string PriceArgumentExceptionErrorMessage = "Price cannot be less or equal to $0.00.";
        private const string HeightArgumentExceptionErrorMessage = "Height cannot be less or equal to 0.00 m.";
        private const string ToStringFormat = "Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}";
        private const int ModelNameNumberOfCharacters = 3;
        private const decimal PriceMinimumValue = 0.00m;
        private const decimal HeightMinimumValue = 0.00m;

        private string model;
        private MaterialType material;
        private decimal price;
        private decimal height;

        public Furniture(string setModel, MaterialType setMaterial, decimal setPrice, decimal setHeight)
        {
            this.Model = setModel;
            this.material = setMaterial;
            this.Price = setPrice;
            this.Height = setHeight;
        }

        public string Model
        {
            get
            {
                return this.model;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(ModelArgumentNullExceptionErrorMessage);
                }

                if (value.Length < ModelNameNumberOfCharacters)
                {
                    throw new ArgumentOutOfRangeException(ModelArgumentOutOfRangeExceptionErrorMessage);
                }

                this.model = value;
            }
        }

        public string Material
        {
            get
            {
                return this.material.ToString();
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value <= PriceMinimumValue)
                {
                    throw new ArgumentOutOfRangeException(PriceArgumentExceptionErrorMessage);
                }
                else
                {
                    this.price = value;
                }
            }
        }

        public decimal Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value <= HeightMinimumValue)
                {
                    throw new ArgumentOutOfRangeException(HeightArgumentExceptionErrorMessage);
                }
                else
                {
                    this.height = value;
                }
            }
        }

        public override string ToString()
        {
            return string.Format(ToStringFormat, this.GetType().Name, this.Model, this.Material, this.Price, this.Height);
        }
    }
}
