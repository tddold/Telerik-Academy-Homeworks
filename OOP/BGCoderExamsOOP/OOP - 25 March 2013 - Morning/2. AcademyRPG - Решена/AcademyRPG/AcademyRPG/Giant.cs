namespace AcademyRPG
{
    using System.Collections.Generic;
    using System.Linq;

    public class Giant : Character, IFighter, IWorldObject, IControllable, IGatherer
    {
        private const int GiantAttackPoints = 150;
        private const int GiantDefensePoints = 80;
        private const int GiantHitPoints = 200;
        private const int GiantNeutralOwner = 0;
        private const int TargetNotFoundReturnValue = -1;
        private const int GatheringStoneBonusPoints = 100;
        private const int TargetOwnerNeutral = 0;

        private int currentGiantAttackPoints;
        private bool collected;

        public Giant(string name, Point position)
            : base(name, position, GiantNeutralOwner)
        {
            this.HitPoints = GiantHitPoints;
            this.AttackPoints = GiantAttackPoints;
            this.collected = false;
        }

        public int AttackPoints
        {
            get
            {
                return this.currentGiantAttackPoints;
            }

            private set
            {
                this.currentGiantAttackPoints = value;
            }
        }

        public int DefensePoints
        {
            get
            {
                return GiantDefensePoints;
            }
        }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            var target = availableTargets.FirstOrDefault(t => t.Owner != TargetOwnerNeutral);

            if (target == null)
            {
                return TargetNotFoundReturnValue;
            }

            int index = availableTargets.IndexOf(target);

            return index;
        }

        public bool TryGather(IResource resource)
        {
            if (resource.Type == ResourceType.Stone)
            {
                if (this.collected == false)
                {
                    this.AttackPoints += GatheringStoneBonusPoints;
                    this.collected = true;
                    return true;
                }

                return true;
            }

            return false;
        }
    }
}
