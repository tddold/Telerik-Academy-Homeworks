namespace FurnitureManufacturer.Models
{
    using System.Text;

    using FurnitureManufacturer.Interfaces;

    public class ConvertibleChair : Chair, IChair, IConvertibleChair, IFurniture
    {
        private const string ConvertibleChairToStringFormat = ", State: {0}";
        private const string CurrentStateConverted = "Converted";
        private const string CurrentStateNormal = "Normal";
        private const decimal ConvertedChairHeight = 0.10m;
        private readonly decimal nonConvertedChairHeight;

        private bool isConverted;

        public ConvertibleChair(string setModel, MaterialType setMaterial, decimal setPrice, decimal setHeight, int setNumberOfLegs)
            : base(setModel, setMaterial, setPrice, setHeight, setNumberOfLegs)
        {
            this.nonConvertedChairHeight = setHeight;
        }

        public bool IsConverted
        {
            get
            {
                return this.isConverted;
            }

            private set
            {
                this.isConverted = value;
            }
        }

        public void Convert()
        {
            if (this.IsConverted)
            {
                this.Height = this.nonConvertedChairHeight;
            }
            else
            {
                this.Height = ConvertedChairHeight;
            }

            this.IsConverted = !this.IsConverted;
        }

        public override string ToString()
        {
            StringBuilder convertibleChairToString = new StringBuilder(base.ToString());

            convertibleChairToString.Append(ConvertibleChairToStringFormat);

            return string.Format(convertibleChairToString.ToString(), this.IsConverted ? CurrentStateConverted : CurrentStateNormal);
        }
    }
}
