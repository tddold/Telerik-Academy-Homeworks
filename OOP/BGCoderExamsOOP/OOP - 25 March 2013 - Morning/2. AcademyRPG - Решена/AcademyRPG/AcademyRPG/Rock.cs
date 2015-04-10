namespace AcademyRPG
{
    public class Rock : StaticObject, IWorldObject, IResource
    {
        private const int DivisionHitPointsBy = 2;

        private int rockHitPoints;

        public Rock(int hitPoints, Point position)
            : base(position)
        {
            this.HitPoints = hitPoints;
        }
        public int Quantity
        {
            get
            {
                return this.HitPoints / DivisionHitPointsBy;
            }
        }

        public ResourceType Type
        {
            get
            {
                return ResourceType.Stone;
            }
        }
    }
}
