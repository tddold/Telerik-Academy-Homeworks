namespace StudentsAndWorkers
{
    using System;

    public class Worker : Human
    {
        private int weekSalary;
        private int workHoursPerDay;

        public Worker(string firstName, string lastName, int weekSalary, int workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public int WeekSalary
        {
            get
            {
                return this.weekSalary;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    this.weekSalary = value;
                }
            }
        }

        public int WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }

            set
            {
                if (value < 0 || value > 24)
                {
                    throw new ArgumentException();
                }
                else
                {
                    this.workHoursPerDay = value;
                }
            }
        }

        public double MoneyPerHour()
        {
            return this.weekSalary / this.workHoursPerDay;
        }
    }
}
