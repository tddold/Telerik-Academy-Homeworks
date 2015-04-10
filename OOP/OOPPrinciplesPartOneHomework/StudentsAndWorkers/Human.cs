namespace StudentsAndWorkers
{
    using System;

    public abstract class Human
    {
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (string.IsNullOrEmpty(value) || char.IsLower(value[0]))
                {
                    throw new ArgumentNullException();
                }
                else
                {
                    this.firstName = value;
                }
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (string.IsNullOrEmpty(value) || char.IsLower(value[0]))
                {
                    throw new ArgumentNullException();
                }
                else
                {
                    this.lastName = value;
                }
            }
        }
    }
}
