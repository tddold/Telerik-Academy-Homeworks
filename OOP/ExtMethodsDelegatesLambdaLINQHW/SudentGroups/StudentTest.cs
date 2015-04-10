namespace SudentGroups
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class StudentTest
    {
        public static List<Student> StudentsInfo()
        {
            List<Student> students = new List<Student>()
            {
                new Student
                {
                    FirstName = "Maria",
                    LastName = "Sharapova",
                    FN = 102306,
                    Tel = 02454199,
                    Email = "mara@yahoo.com",
                    Marks = new List<int> { 6, 4, 2, 3, 4 },
                    GroupNumber = 3,
                },

                new Student
                {
                    FirstName = "Ivan",
                    LastName = "Georgiev",
                    FN = 102006,
                    Tel = 03315420,
                    Email = "i.georgiev@abv.bg",
                    Marks = new List<int> { 2, 3, 2, 4, 4, 3 },
                    GroupNumber = 2
                },

                new Student
                {
                    FirstName = "Albena",
                    LastName = "Kostova",
                    FN = 478106,
                    Tel = 02994101,
                    Email = "ak@abv.bg",
                    Marks = new List<int> { 6, 6, 5, 6 },
                    GroupNumber = 2
                },

                new Student
                {
                    FirstName = "Ivelina",
                    LastName = "Kostova",
                    FN = 47812,
                    Tel = 02994101,
                    Email = "ivka@gmail.bg",
                    Marks = new List<int> { 6 },
                    GroupNumber = 2
                },

                new Student
                {
                    FirstName = "Stamat",
                    LastName = "Rusev",
                    FN = 10333,
                    Tel = 02999111,
                    Email = "st.rusev90@yahoo.com",
                    Marks = new List<int> { },
                    GroupNumber = 1
                },

                new Student
                {
                    FirstName = "Gosho",
                    LastName = "Goshov",
                    FN = 78100,
                    Tel = 04877310,
                    Email = "gosho_badit@abv.bg",
                    Marks = new List<int> { 6, 6, 6, 6, 6, 6, 6, 6 },
                    GroupNumber = 3
                },

                new Student
                {
                    FirstName = "Aleks",
                    LastName = "Penkova",
                    FN = 331406,
                    Tel = 14899147,
                    Email = "aleks91@gmail.com",
                    Marks = new List<int> { 4, 2, 2, 5 },
                    GroupNumber = 1
                },

                new Student
                {
                    FirstName = "Pesho",
                    LastName = "Penkov",
                    FN = 66178,
                    Tel = 02179441,
                    Email = "peshkata@abv.bg",
                    Marks = new List<int> { 4 },
                    GroupNumber = 3
                },

                new Student
                {
                    FirstName = "Bojana",
                    LastName = "Ivanova",
                    FN = 66179,
                    Tel = 02103341,
                    Email = "bojana_baby@yahoo.com",
                    Marks = new List<int> { 5, 3 },
                    GroupNumber = 3
                },
            };

            return students;
        }

        public static void Print<T>(T list) where T : IEnumerable<string>
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        public static void Main()
        {
            var students = StudentsInfo();

            List<Group> departments = new List<Group>()
            {
                new Group { GroupNumber = 1, DepartmentName = "Mathematics" },
                new Group { GroupNumber = 2, DepartmentName = "Chemistry" },
                new Group { GroupNumber = 3, DepartmentName = "Physics" },
            };

            Console.WriteLine("Order student by first name using LINQ query:");
            Print(Extensions.OrderStudentByFirstNameLINQ(students));

            Console.WriteLine("\nOrder student by first name using extension methods:");
            Print(Extensions.OrderStudentByFirstNameLambda(students));

            Console.WriteLine("\nPlease press a key to clear the console and to continue.");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("All students that have email in abv.bg:");
            Print(Extensions.ExtractStudentsByEmail(students));

            Console.WriteLine("\nAll students with phones in Sofia:");
            Print(Extensions.ExtractStudentsByPhoneInSofia(students));

            Console.WriteLine("\nAll students that have at least one mark Excellent (6):");

            var studentsMark = students
                .Where(st => st.Marks.Contains(6))
                .Select(st => new
                {
                    FullName = st.FirstName + " " + st.LastName,
                    Marks = string.Join(", ", st.Marks)
                });

            foreach (var item in studentsMark)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nAll students with exactly two marks \"2\":");
            Print(Extensions.ExtractStudentsWithTwoMarks(students));

            Console.WriteLine("\nAll marks of the students that enrolled in 2006:");
            Print(Extensions.ExtractMarksByFN(students));

            Console.WriteLine("\nPlease press a key to clear the console and to continue.");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("All students from \"Mathematics\" department.:");

            var studentsByDepartment =
                from st in students
                join dp in departments
                on st.GroupNumber equals dp.GroupNumber
                select new
                {
                    Name = st.FirstName + " " + st.LastName,
                    Department = dp.DepartmentName
                };

            foreach (var item in studentsByDepartment)
            {
                if (item.Department == "Mathematics")
                {
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine("\nThe string with maximum length - student with the longest name:");

            var studentLongestFirstName = students.OrderByDescending(x => x.FirstName.Length).First().FirstName;
            Console.WriteLine(studentLongestFirstName);

            Console.WriteLine("\nAll students grouped by GroupNumber (LINQ):");

            var studentsGroup =
                from st in students
                group st by st.GroupNumber into stGroups
                select new
                {
                    GroupNumber = stGroups.Key,
                    Students = stGroups
                };

            foreach (var st in studentsGroup)
            {
                Console.WriteLine("\nGroup {0}, students:\n", st.GroupNumber);

                foreach (var item in st.Students)
                {
                    Console.WriteLine(item.FirstName + " " + item.LastName);
                }
            }

            Console.WriteLine("\nPlease press a key to clear the console and to continue.");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("All students grouped by GroupName (extensions):\n");

            var groupByExntesions = students.OrderBy(st => st.GroupNumber);

            foreach (var item in groupByExntesions)
            {
                string currentDepartment = string.Join(", ", departments
                    .Where(st => st.GroupNumber == item.GroupNumber)
                    .Select(dp => dp.DepartmentName));

                Console.WriteLine("{0,10} {1,10} - Department: {2, 1}", item.FirstName, item.LastName, currentDepartment);
            }
        }
    }
}
