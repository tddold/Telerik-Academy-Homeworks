namespace AcademyRPG
{
    public class House : StaticObject, IWorldObject
    {
        private const int HouseHitPoints = 500;

        public House(Point position, int owner)
            : base(position, owner)
        {
            this.HitPoints = HouseHitPoints;
        }
    }
}
