namespace AcademyRPG
{
    public class ExtendedEngine : Engine
    {
        private const string KnightType = "knight";
        private const string HouseType = "house";
        private const string GiantType = "giant";
        private const string RockType = "rock";
        private const string NinjaType = "ninja";

        public override void ExecuteCreateObjectCommand(string[] commandWords)
        {
            switch (commandWords[1])
            {
                case KnightType:
                    {
                        string name = commandWords[2];
                        Point position = Point.Parse(commandWords[3]);
                        int owner = int.Parse(commandWords[4]);
                        this.AddObject(new Knight(name, position, owner));
                        break;
                    }

                case HouseType:

                    {
                        Point position = Point.Parse(commandWords[2]);
                        int owner = int.Parse(commandWords[3]);
                        this.AddObject(new House(position, owner));
                        break;
                    }

                case GiantType:
                    {
                        string name = commandWords[2];
                        Point position = Point.Parse(commandWords[3]);
                        this.AddObject(new Giant(name, position));
                        break;
                    }

                case RockType:
                    {
                        int hitPoints = int.Parse(commandWords[2]);
                        Point position = Point.Parse(commandWords[3]);
                        this.AddObject(new Rock(hitPoints, position));
                        break;
                    }

                case NinjaType:
                    {
                        string name = commandWords[2];
                        Point position = Point.Parse(commandWords[3]);
                        int owner = int.Parse(commandWords[4]);
                        this.AddObject(new Ninja(name, position, owner));
                        break;
                    }

                default:
                    base.ExecuteCreateObjectCommand(commandWords);
                    break;
            }
        }
    }
}
