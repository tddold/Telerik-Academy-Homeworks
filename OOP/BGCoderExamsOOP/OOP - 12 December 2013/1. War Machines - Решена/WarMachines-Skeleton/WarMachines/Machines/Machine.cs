namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using WarMachines.Interfaces;

    public abstract class Machine : IMachine
    {
        private const string NameNullExceptionErrorMessage = "Name cannot be null or empty";
        private const string TargetsNullExceptionErrorMessage = "Targets list cannot be null";
        private const string PilotNullExceptionErrorMessage = "Pilot cannot be null";
        private const string HealthPointsOutOfRangeErrorMessage = "Health points cannot be less than {0}";
        private const int HealthPointsMinimumValue = 0;
        private const string AttackPointsOutOfRangeErrorMessage = "Attack points cannot be less than {0}";
        private const int AttackPointsMinimumValue = 0;
        private const string DefensePointsOutOfRangeErrorMessage = "Defense points cannot be less than {0}";
        private const int DefensePointsMinimumValue = 0;
        private const string MachineNameToStringFormat = "- {0}";
        private const string MachineTypeToStringFormat = " *Type: {0}";
        private const string MachineHealthToStringFormat = " *Health: {0}";
        private const string MachineAttackToStringFormat = " *Attack: {0}";
        private const string MachineDefenseToStringFormat = " *Defense: {0}";
        private const string MachineTargetsToStringFormat = " *Targets: {0}";
        private const string TargesNotFoundMessage = "None";
        private const int TargetsCountMinimumValue = 0;
        private const string StringJoinElementSeparator = ", ";

        private string name;
        private IPilot pilot;
        private double healthPoints;
        private double attackPoints;
        private double defensePoints;
        private IList<string> targets;

        public Machine(string name, IPilot pilot, double healthPoints, double attackPoints, double defensePoints)
        {
            this.Name = name;
            this.Pilot = pilot;
            this.HealthPoints = healthPoints;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
            this.Targets = new List<string>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(NameNullExceptionErrorMessage);
                }

                this.name = value;
            }
        }

        public IPilot Pilot
        {
            get
            {
                return this.pilot;
            }

            set
            {
                //if (pilot == null)
                //{
                //    throw new ArgumentNullException(PilotNullExceptionErrorMessage);
                //}

                this.pilot = value;
            }
        }

        public double HealthPoints
        {
            get
            {
                return this.healthPoints;
            }

            set
            {
                if (value < HealthPointsMinimumValue)
                {
                    throw new ArgumentOutOfRangeException(string.Format(HealthPointsOutOfRangeErrorMessage, HealthPointsMinimumValue));
                }

                this.healthPoints = value;
            }
        }

        public double AttackPoints
        {
            get
            {
                return this.attackPoints;
            }

            protected set
            {
                if (value < AttackPointsMinimumValue)
                {
                    throw new ArgumentOutOfRangeException(string.Format(AttackPointsOutOfRangeErrorMessage, AttackPointsMinimumValue));
                }

                this.attackPoints = value;
            }
        }

        public double DefensePoints
        {
            get
            {
                return this.defensePoints;
            }

            protected set
            {
                if (value < DefensePointsMinimumValue)
                {
                    throw new ArgumentOutOfRangeException(string.Format(DefensePointsOutOfRangeErrorMessage, DefensePointsMinimumValue));
                }

                this.defensePoints = value;
            }
        }

        public IList<string> Targets
        {
            get
            {
                return this.targets;
            }

            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(TargetsNullExceptionErrorMessage);
                }

                this.targets = value;
            }
        }

        public void Attack(string target)
        {
            this.targets.Add(target);
        } 

        public override string ToString()
        {
            StringBuilder machineToString = new StringBuilder();

            machineToString.AppendLine(string.Format(MachineNameToStringFormat, this.Name));
            machineToString.AppendLine(string.Format(MachineTypeToStringFormat, this.GetType().Name));
            machineToString.AppendLine(string.Format(MachineHealthToStringFormat, this.HealthPoints));
            machineToString.AppendLine(string.Format(MachineAttackToStringFormat, this.AttackPoints));
            machineToString.AppendLine(string.Format(MachineDefenseToStringFormat, this.DefensePoints));
            
            if (this.Targets.Count == 0)
            {
                machineToString.AppendLine(string.Format(MachineTargetsToStringFormat, TargesNotFoundMessage));
            }
            else
            {
                machineToString.AppendLine(string.Format(MachineTargetsToStringFormat, string.Join(", ", this.Targets)));
            }

            return machineToString.ToString();
        }
    }
}
