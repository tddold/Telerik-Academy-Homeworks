namespace AcademyEcosystem
{
    public class Grass : Plant
    {
        private const int GrassSize = 2;

        public Grass(Point position)
            : base(position, GrassSize)
        {
        }

        public override void Update(int time)
        {
            if (this.IsAlive)
            {
                this.Size += time;
            }

            base.Update(time);
        }
    }
}
