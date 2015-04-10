namespace Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public abstract class Animal : ISound
    {
        private int age;
        private string name;
        private Gender gender;

        public Animal(string name, int age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public int Age
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

        public Gender Gender
        {
            get
            {
                return this.gender;
            }

            set
            {
                this.gender = value;
            }
        }

        public static double CalculateAverageAge(IEnumerable<Animal> animal)
        {
            return animal.Average(a => a.Age);
        }

        public abstract string ProduceSound();
    }
}
