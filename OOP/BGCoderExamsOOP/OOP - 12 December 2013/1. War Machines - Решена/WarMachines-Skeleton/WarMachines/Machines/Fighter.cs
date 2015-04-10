namespace WarMachines.Machines
{
    using System.Text;

    using WarMachines.Interfaces;

    public class Fighter : Machine, IFighter
    {
        private const string FighterStealtStringFormat = " *Stealth: {0}";
        private const string FighterStealtModeActivatedMessage = "ON";
        private const string FighterStealtModeDeactivatedMessage = "OFF";
        private const int FighterInitialHealthPoints = 200;
        private bool stealthMode;

        public Fighter(string name, double attackPoints, double defensePoints, bool stealthMode)
            : base(name, null, FighterInitialHealthPoints, attackPoints, defensePoints)
        {
            this.StealthMode = stealthMode;
        }

        public bool StealthMode
        {
            get
            {
                return this.stealthMode;
            }

            private set
            {
                this.stealthMode = value;
            }
        }

        public void ToggleStealthMode()
        {
            if (this.StealthMode)
            {
                this.StealthMode = !this.StealthMode;
            }
            else
            {
                this.StealthMode = !this.StealthMode;
            }
        }

        public override string ToString()
        {
            StringBuilder fighterToString = new StringBuilder(base.ToString());

            fighterToString.AppendLine(string.Format(FighterStealtStringFormat, 
                this.StealthMode ? FighterStealtModeActivatedMessage : FighterStealtModeDeactivatedMessage));

            return fighterToString.ToString().Trim();
        }
    }
}
