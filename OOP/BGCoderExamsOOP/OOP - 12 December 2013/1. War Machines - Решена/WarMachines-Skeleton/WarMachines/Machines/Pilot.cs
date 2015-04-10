namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using WarMachines.Interfaces;

    public class Pilot : IPilot
    {
        private const string NameNullExceptionErrorMessage = "Name cannot be null or empty";
        private const string PilotDataHeaderStringFormat = "{0} - {1} {2}";
        private const string LackOfMachinesMessage = "no";
        private const string SingleMachineMessage = "machine";
        private const string ManyMachinesMessage = "machines";
        private const int ZeroMachines = 0;
        private const int OneMachine = 1;

        private string name;
        private ICollection<IMachine> machines;

        public Pilot(string name)
        {
            this.Name = name;
            this.machines = new List<IMachine>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(NameNullExceptionErrorMessage);
                }

                this.name = value;
            }
        }

        public void AddMachine(IMachine machine)
        {
            this.machines.Add(machine);
        }

        public string Report()
        {
            StringBuilder pilotToString = new StringBuilder();

            pilotToString.AppendLine(string.Format(PilotDataHeaderStringFormat, 
                this.Name,
                this.machines.Count == ZeroMachines ? LackOfMachinesMessage : this.machines.Count.ToString(),
                this.machines.Count == OneMachine ? SingleMachineMessage : ManyMachinesMessage));

            var orderedMachines = this.machines.OrderBy(m => m.HealthPoints).ThenBy(m => m.Name);

            foreach (var machine in orderedMachines)
            {
                pilotToString.AppendLine(machine.ToString());
            }

            return pilotToString.ToString().Trim();
        }
    }
}
