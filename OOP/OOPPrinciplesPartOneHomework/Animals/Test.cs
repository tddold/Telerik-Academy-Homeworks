namespace Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    // Problem 3. Animal hierarchy

    // Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. Dogs, frogs and cats are Animals. 
    // All animals can produce sound (specified by the ISound interface). Kittens and tomcats are cats. 
    // All animals are described by age, name and sex. Kittens can be only female and tomcats can be only male. 
    // Each animal produces a specific sound.
    // Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ).
    public class Test
    {
        public static string CalculateAverageAge(List<Dog> animal)
        {
            var calculate = animal.Average(a => a.Age).ToString();

            return calculate;
        }

        public static void Main()
        {
            List<Dog> dogs = new List<Dog>()
            {
                new Dog("Sharo", 5, Gender.Male),
                new Dog("Penka", 1, Gender.Female),
                new Dog("Mara", 3, Gender.Female),
                new Dog("Ivan", 4, Gender.Male)
            };

            List<Cat> cats = new List<Cat>()
            {
                new Cat("Ivcho", 10, Gender.Male),
                new Cat("Penka", 2, Gender.Female),
                new Cat("Marian", 7, Gender.Male),
                new Cat("Ivanka", 4, Gender.Female)
            };

            List<Frog> frogs = new List<Frog>()
            {
                new Frog("Doncho", 2, Gender.Male),
                new Frog("Petko", 2, Gender.Male),
                new Frog("Albena", 3, Gender.Female),
                new Frog("Ivanka", 1, Gender.Female)
            };

            List<Kitten> kittens = new List<Kitten>()
            {
                new Kitten("Maca", 4),
                new Kitten("Penka", 3),
                new Kitten("Bojana", 4),
                new Kitten("Ivanka", 4)
            };

            List<Tomcat> tomcats = new List<Tomcat>()
            {
                new Tomcat("Pesho", 1),
                new Tomcat("Gosho", 10),
                new Tomcat("Stamat", 12),
                new Tomcat("Ivancho", 3)
            };

            Console.WriteLine("Dogs average age: {0}", Animal.CalculateAverageAge(dogs));
            Console.WriteLine("Cats average age: {0}", Animal.CalculateAverageAge(cats));
            Console.WriteLine("Frogs average age: {0}", Animal.CalculateAverageAge(frogs));
            Console.WriteLine("Kittens average age: {0}", Animal.CalculateAverageAge(kittens));
            Console.WriteLine("Tocats average age: {0}", Animal.CalculateAverageAge(tomcats));
        }
    }
}
