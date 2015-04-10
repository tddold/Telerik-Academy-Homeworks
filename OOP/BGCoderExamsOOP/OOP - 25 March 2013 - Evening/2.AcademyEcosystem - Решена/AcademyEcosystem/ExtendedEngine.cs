namespace AcademyEcosystem
{
    public class ExtendedEngine : Engine
    {
        private const string WolfType = "wolf";
        private const string LionType = "lion";
        private const string GrassType = "grass";
        private const string BoarType = "boar";
        private const string ZombieType = "zombie";

        protected override void ExecuteBirthCommand(string[] commandWords)
        {
            string animalType = commandWords[1];

            switch (animalType)
            {
                case WolfType:
                    {
                        string name = commandWords[2];
                        Point position = Point.Parse(commandWords[3]);
                        this.AddOrganism(new Wolf(name, position));
                        break;
                    }

                case LionType:
                    {
                        string name = commandWords[2];
                        Point position = Point.Parse(commandWords[3]);
                        this.AddOrganism(new Lion(name, position));
                        break;
                    }

                case GrassType:
                    {
                        Point position = Point.Parse(commandWords[2]);
                        this.AddOrganism(new Grass(position));
                        break;
                    }

                case BoarType:
                    {
                        string name = commandWords[2];
                        Point position = Point.Parse(commandWords[3]);
                        this.AddOrganism(new Boar(name, position));
                        break;
                    }

                case ZombieType:
                    {
                        string name = commandWords[2];
                        Point position = Point.Parse(commandWords[3]);
                        this.AddOrganism(new Zombie(name, position));
                        break;
                    }

                default:
                    base.ExecuteBirthCommand(commandWords);
                    break;
            }
        }
    }
}
