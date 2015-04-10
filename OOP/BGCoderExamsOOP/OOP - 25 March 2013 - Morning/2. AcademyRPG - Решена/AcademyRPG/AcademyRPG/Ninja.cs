namespace AcademyRPG
{
    using System.Collections.Generic;
    using System.Linq;

    public class Ninja : Character, IFighter, IWorldObject, IControllable, IGatherer
    {
        private const int MultipleQuantityBy = 2;
        private const int TargetNotFoundReturnValue = -1;
        private const int NinjaHitPoints = 1;
        private const int NinjaInitialAttackPoints = 0;

        private int ninjaAttackPoints;

        public Ninja(string name, Point position, int owner)
            : base(name, position, owner)
        {
            this.HitPoints = NinjaHitPoints;
            this.AttackPoints = NinjaInitialAttackPoints;
        }

        public int AttackPoints
        {
            get
            {
                return this.ninjaAttackPoints;
            }

            private set
            {
                this.ninjaAttackPoints = value;
            }
        }

        public int DefensePoints
        {
            get
            {
                return int.MaxValue;
            }
        }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            var targets = availableTargets.FindAll(t => t.Owner != 0 && t.Owner != this.Owner);

            var targetWithHighestPoints = targets.Max(t => t.HitPoints);

            foreach (var target in targets)
            {
                if (target.HitPoints == targetWithHighestPoints)
                {
                    return availableTargets.IndexOf(target);
                }
            }

            return TargetNotFoundReturnValue;
        }

        public bool TryGather(IResource resource)
        {
            if (resource.Type == ResourceType.Lumber)
            {
                this.AttackPoints += resource.Quantity;
                return true;
            }

            if (resource.Type == ResourceType.Stone)
            {
                this.AttackPoints += resource.Quantity * MultipleQuantityBy;
                return true;
            }

            return false;
        }
    }
}
