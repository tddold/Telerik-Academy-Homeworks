namespace SchoolClasses
{
    using System;

    public class People
    {
        private string name;

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
                    throw new ArgumentException();
                }
                else
                {
                    this.name = value;
                }
            }
        }
    }
}
