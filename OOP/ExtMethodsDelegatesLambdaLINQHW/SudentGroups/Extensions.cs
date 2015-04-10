namespace SudentGroups
{
    using System.Collections.Generic;
    using System.Linq;

    public class Extensions
    {
        private const int DivisibleNumber = 1000000;

        public static IEnumerable<string> OrderStudentByFirstNameLINQ(List<Student> students)
        {
            var orderedStudents =
                from st in students
                orderby st.FirstName
                select st.FirstName;

            return orderedStudents;
        }

        public static IEnumerable<string> OrderStudentByFirstNameLambda(List<Student> students)
        {
            var orderedStudent = students
                .OrderBy(st => st.FirstName)
                .Select(st => st.FirstName);

            return orderedStudent;
        }

        public static IEnumerable<string> ExtractStudentsByEmail(List<Student> students)
        {
            var studentsEmail = students
                .Where(st => st.Email.Contains("abv.bg"))
                .Select(st => st.FirstName);

            return studentsEmail;
        }

        public static IEnumerable<string> ExtractStudentsByPhoneInSofia(List<Student> students)
        {
            var studentsPhone = students
                .Where(st => st.Tel / DivisibleNumber == 2)
                .Select(st => st.FirstName);

            return studentsPhone;
        }

        public static IEnumerable<string> ExtractStudentsWithTwoMarks(List<Student> students)
        {
            var studentsWithTwoMarks = students
                .Where(st => st.Marks.Count(m => m == 2) == 2)
                .Select(st => st.FirstName + " " + st.LastName);

            return studentsWithTwoMarks;
        }

        public static IEnumerable<string> ExtractMarksByFN(List<Student> students)
        {
            var marksByFN = students
                .Where(st => st.FN % 100 == 6)
                .Select(st => string.Format("{0} {1}, MARKS = {2}", st.FirstName, st.LastName, string.Join(", ", st.Marks)));

            return marksByFN;
        }

        // Problem 9. Student groups
        // Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
        // Create a List<Student> with sample students. Select only the students that are from group number 2.
        // Use LINQ query. Order the students by FirstName.

        // Problem 10. Student groups extensions
        // Implement the previous using the same query expressed with extension methods.

        // Problem 11. Extract students by email
        // Extract all students that have email in abv.bg.
        // Use string methods and LINQ.

        // Problem 12. Extract students by phone
        // Extract all students with phones in Sofia.
        // Use LINQ.

        // Problem 13. Extract students by marks
        // Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks.
        // Use LINQ.

        // Problem 14. Extract students with two marks
        // Write down a similar program that extracts the students with exactly two marks "2".
        // Use extension methods.

        // Problem 15. Extract marks
        // Extract all Marks of the students that enrolled in 2006. (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).

        // Problem 16.* Groups
        // Create a class Group with properties GroupNumber and DepartmentName.
        // Introduce a property GroupNumber in the Student class.
        // Extract all students from "Mathematics" department.
        // Use the Join operator.

        // Problem 17. Longest string
        // Write a program to return the string with maximum length from an array of strings.
        // Use LINQ.

        // Problem 18. Grouped by GroupNumber
        // Create a program that extracts all students grouped by GroupNumber and then prints them to the console.
        // Use LINQ.

        // Problem 19. Grouped by GroupName extensions
        // Rewrite the previous using extension methods.
    }
}
