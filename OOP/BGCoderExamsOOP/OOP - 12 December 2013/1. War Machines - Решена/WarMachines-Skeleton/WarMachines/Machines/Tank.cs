namespace WarMachines.Machines
{
    using System.Text;

    using WarMachines.Interfaces;

    public class Tank : Machine, ITank
    {
        private const string TankDefenseStringFormat = " *Defense: {0}";
        private const string TankDefenseModeActivatedMessage = "ON";
        private const string TankDefenseModeDeactivatedMessage = "OFF";
        private const int TankInitialHealthPoints = 100;
        private const int BonusDefensePoint = 30;
        private const int BonusAttackPoint = 40;
        private bool defenseMode;

        public Tank(string name, double attackPoints, double defensePoints)
            : base(name, null, TankInitialHealthPoints, attackPoints, defensePoints)
        {
            this.DefensePoints += BonusDefensePoint;
            this.AttackPoints -= BonusAttackPoint;
            this.DefenseMode = true;
        }

        public bool DefenseMode
        {
            get
            {
                return this.defenseMode;
            }

            private set
            {
                this.defenseMode = value;
            }
        }

        public void ToggleDefenseMode()
        {
            if (this.DefenseMode)
            {
                this.DefensePoints -= BonusDefensePoint;
                this.AttackPoints += BonusAttackPoint;
                this.DefenseMode = false;
            }
            else
            {
                this.DefensePoints -= BonusDefensePoint;
                this.AttackPoints += BonusAttackPoint;
                this.DefenseMode = true;
            }
        }

        public override string ToString()
        {
            StringBuilder tankToString = new StringBuilder(base.ToString());

            tankToString.Append(string.Format(TankDefenseStringFormat,
                this.DefenseMode ? TankDefenseModeActivatedMessage : TankDefenseModeDeactivatedMessage));

            return tankToString.ToString().Trim();
        }
    }
}
