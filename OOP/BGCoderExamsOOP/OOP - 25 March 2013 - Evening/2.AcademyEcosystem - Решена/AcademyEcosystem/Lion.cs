namespace AcademyEcosystem
{
    public class Lion : Animal, ICarnivore
    {
        private const int LionSize = 6;
        private const int CurrentSizeMultiplicationBy = 2;
        private const int NoAnimalToEatReturnValue = 0;

        public Lion(string name, Point position)
            : base(name, position, LionSize)
        {
        }

        public int TryEatAnimal(Animal animal)
        {
            if (animal != null)
            {
                if (animal.Size <= this.Size * CurrentSizeMultiplicationBy)
                {
                    this.Size++;
                    return animal.GetMeatFromKillQuantity();
                }
            }

            return NoAnimalToEatReturnValue;
        }
    }
}
