namespace PersonClass
{
    using System;
    using System.Text;

    // Problem 4. Person class

    // Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value. 
    // Override ToString() to display the information of a person and if age is not specified – to say so.
    // Write a program to test this functionality.
    public class Person
    {
        private string name;
        private int? age;

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
                    throw new ArgumentNullException();
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public int? Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    this.age = value;
                }
            }
        }

        public override string ToString()
        {
            StringBuilder personTostring = new StringBuilder();

            personTostring.Append(string.Format("Name: {0} | ", this.Name));
            personTostring.Append(string.Format("Age: {0}", this.Age == null ? "No information about age" : this.Age.ToString()));

            return personTostring.ToString();
        }
    }
}
