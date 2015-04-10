namespace AcademyEcosystem
{
    public class Boar : Animal, ICarnivore, IHerbivore
    {
        private const int BoarSize = 4;
        private const int BoarBiteSize = 2;
        private const int NoAnimalToEatReturnValue = 0;
        private const int NoPlantToEatReturnValue = 0;

        public Boar(string name, Point position)
            : base(name, position, BoarSize)
        {
        }

        public int TryEatAnimal(Animal animal)
        {
            if (animal != null)
            {
                if (animal.Size <= this.Size)
                {
                    return animal.GetMeatFromKillQuantity();
                }
            }

            return NoAnimalToEatReturnValue;
        }

        public int EatPlant(Plant plant)
        {
            if (plant != null)
            {
                this.Size++;
                return plant.GetEatenQuantity(BoarBiteSize);
            }

            return NoPlantToEatReturnValue;
        }
    }
}
