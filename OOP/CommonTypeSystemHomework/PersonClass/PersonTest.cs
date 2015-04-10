namespace PersonClass
{
    using System;

    public class PersonTest
    {
        public static void Main()
        {
            Person firstPerson = new Person();
            firstPerson.Name = "Albena";
            firstPerson.Age = 23;

            Person secondPerson = new Person();
            secondPerson.Name = "Ivaylo";
            secondPerson.Age = null;

            Console.WriteLine(firstPerson);
            Console.WriteLine(secondPerson);
        }
    }
}
