namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    // Problem 2. Students and workers

    // Define abstract class Human with first name and last name. Define new class Student which is derived from Human and has new field – grade. 
    // Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay and method MoneyPerHour() that returns money 
    // earned by hour by the worker. Define the proper constructors and properties for this hierarchy.
    // Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
    // Initialize a list of 10 workers and sort them by money per hour in descending order.
    // Merge the lists and sort them by first name and last name.
    public class Test
    {
        public static void ForEach(IEnumerable<string> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }

        public static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student("Ivan", "Ivanova", 12),
                new Student("Penka", "Georgieva", 7),
                new Student("Martin", "Peshov", 11),
                new Student("Mara", "Penkova", 7),
                new Student("Joro", "Petkov", 9),
                new Student("Stamat", "Ivailov", 3),
                new Student("Albena", "Ivanov", 10),
                new Student("Zornitsa", "Penkova", 10),
                new Student("Elena", "Troqnova", 1),
                new Student("Iva", "Sharapova", 7),
            };

            var orderedStudents = students
                .OrderBy(st => st.Grade)
                .Select(st => string.Format("Grade: {2,2} Full name: {0} {1}", st.FirstName, st.LastName, st.Grade));

            Console.WriteLine("Students ordered by grade:\n");
            ForEach(orderedStudents);

            List<Worker> workers = new List<Worker>()
            {
                new Worker("Ivaylo", "Petrov", 1500, 8),
                new Worker("Dimitar", "Stoyanov", 3500, 8),
                new Worker("Albena", "Georgieva", 400, 12),
                new Worker("Pesho", "Peshov", 500, 5),
                new Worker("Mara", "Goshova", 410, 8),
                new Worker("Brat", "Pit", 100, 12),
                new Worker("Joreto", "Ivanov", 900, 6),
                new Worker("Penka", "Martinova", 1500, 4),
                new Worker("Ivan", "Ivanov", 180, 3),
                new Worker("Ganka", "Petkova", 450, 8)
            };

            Console.WriteLine("\nWorkers sorted by money per hour:\n");
            var orderedWorkers = workers
                .OrderByDescending(st => st.MoneyPerHour())
                .Select(st => string.Format("Money per hour: {0,10:C} Full name: {1} {2}", st.MoneyPerHour(), st.FirstName, st.LastName));
            
            ForEach(orderedWorkers);

            Console.WriteLine("\nPlease press a key to clear the console and to continue.");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("The same lists, but now ordered by first and last name:\n");

            ForEach(students
                .OrderBy(st => st.FirstName)
                .ThenBy(st => st.LastName)
                .Select(st => string.Format("{0,10} {1,10} {2,3}", st.FirstName, st.LastName, st.Grade)));

            Console.WriteLine("\n");

            ForEach(workers
                .OrderBy(st => st.FirstName)
                .ThenBy(st => st.LastName)
                .Select(st => string.Format("Full name: {0, 7} {1, 10}   Money per hour: {2,10:C}", st.FirstName, st.LastName, st.MoneyPerHour())));
        }
    }
}
