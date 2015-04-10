namespace FirstBeforeLast
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StudentTest
    {
        public static void ForEach(IEnumerable<Student> result)
        {
            foreach (var item in result)
            {
                Console.WriteLine("{0} {1}", item.FirstName, item.LastName);
            }
        }

        public static void Main()
        {
            var students = new List<Student>()
            {
                new Student("Albena", "March", 23),
                new Student("Dinko", "Peshev", 18),
                new Student("Elena", "Martinova", 22),
                new Student("Martin", "Sharapov", 19),
                new Student("Dinko", "Kalinov", 27),
                new Student("Penka", "Kostova", 15),
            };

            var result = Student.FirstNameBeforeLast(students);

            Console.WriteLine("All students whose first name is before its last name:\n");
            ForEach(result);

            // Problem 4
            var firstAndLastName =
                from st in students
                where st.Age > 18 && st.Age < 24
                select st;

            Console.WriteLine("\nAll students between 18 and 24 years:\n");
            ForEach(firstAndLastName);

            // Problem 5
            var sortedStudentsWithLambda = students
                .OrderByDescending(st => st.FirstName)
                .ThenByDescending(st => st.LastName);

            Console.WriteLine("\nAll students sorted in descending order - with lambda expressions:\n");
            ForEach(sortedStudentsWithLambda);

            var sortedStudentsWithLINQ =
                from st in students
                orderby st.FirstName descending 
                select st;

            Console.WriteLine("\nsorted with LINQ querie\n");
            ForEach(sortedStudentsWithLINQ);
        }
    }
}
