namespace AcademyRPG
{
    using System.Collections.Generic;
    using System.Linq;

    public class Knight : Character, IFighter, IWorldObject, IControllable
    {
        private const int KnightAttackPoints = 100;
        private const int KnightDefencePoints = 100;
        private const int KnightHitPoints = 100;
        private const int NeutralPlayerIndex = 0;
        private const int TargetNotFoundReturnValue = -1;

        public Knight(string name, Point position, int owner)
            : base(name, position, owner)
        {
            this.HitPoints = KnightHitPoints;
        }

        public int AttackPoints
        {
            get 
            {
                return KnightAttackPoints;
            }
        }

        public int DefensePoints
        {
            get 
            {
                return KnightDefencePoints;
            }
        }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            var target = availableTargets.FirstOrDefault(t => t.Owner != NeutralPlayerIndex && this.Owner != t.Owner);

            if (target == null)
            {
                return TargetNotFoundReturnValue;
            }

            var index = availableTargets.IndexOf(target);

            return index;
        }
    }
}
