namespace FurnitureManufacturer.Models
{
    using FurnitureManufacturer.Interfaces;

    public class AdjustableChair : Chair, IChair, IAdjustableChair, IFurniture
    {
        public AdjustableChair(string setModel, MaterialType setMaterial, decimal setPrice, decimal setHeight, int setNumberOfLegs)
            : base(setModel, setMaterial, setPrice, setHeight, setNumberOfLegs)
        {
        }

        public void SetHeight(decimal height)
        {
            this.Height = height;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
