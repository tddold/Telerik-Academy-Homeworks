namespace StudentClass
{
    using System;

    // Problem 1. Student class
    // Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address, 
    // mobile phone e-mail, course, specialty, university, faculty. Use an enumeration for the specialties, universities and faculties.
    // Override the standard methods, inherited by System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.
       
    // Problem 2. IClonable
    // Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's fields into a 
    // new object of type Student.
       
    // Problem 3. IComparable
    // Implement the IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order) and 
    // by social security number (as second criteria, in increasing order).
    public class StudentClassTest
    {
        public static void Main()
        {
            Student firstSudent = new Student("Pesho", "Ivanov", "Georgiev", 9003177211, "Sofia, № 411 Georgi Kalinov street",
                "0899471511", "pesho.Georgiev@yahoo.com", 4, Specialty.ComputerSciences, University.Birmingham, Faculty.Technology);

            Student secondSudent = new Student("Pesho", "Peshov", "Ivanov", 9003177211, "Sofia, № 411 Georgi Kalinov street",
                "0877415500", "sueprman@abv.bg", 1, Specialty.EarthSciences, University.Lancaster, Faculty.PhysicalSciences);

            Student thirdSudent = new Student("Ivelina", "Stamatova", "Petkovva", 9101114512, "Sofia, № 21 Georgi Kalinov street",
                "0899471511", "ivka@yahoo.com", 3, Specialty.Journalism, University.Harvard, Faculty.HumanitiesSocialSciences);

            Student fourthSudent = new Student("Stamat", "Ivanov", "Stamatov", 9309121411, "Sofia, № 9 Georgi Kalinov street",
                "0899510100", "stamat.ivanov@abv.bg", 3, Specialty.BiologicalSciences, University.Durham, Faculty.ClinicalMedicine);

            Console.WriteLine(firstSudent);
            Console.WriteLine("\nAre equals: {0}", firstSudent == secondSudent);
            Console.WriteLine("HashCode: {0}", thirdSudent.GetHashCode());

            Console.WriteLine("Please press a key do clear the console and to continue.");
            Console.ReadKey();
            Console.Clear();

            // Clone student
            var newStudentClone = firstSudent.Clone();

            // Change some thing in the cloning
            (newStudentClone as Student).FirstName = "Doncho";
            (newStudentClone as Student).LastName = "Petkov";

            Console.WriteLine("The cloning with some changes:\n");
            Console.WriteLine(newStudentClone);

            Console.WriteLine("The original:\n");
            Console.WriteLine(firstSudent);

            // Using CompareTo
            Console.WriteLine("Compare two student by names and SSN: {0}", firstSudent.CompareTo(secondSudent));
        }
    }
}
