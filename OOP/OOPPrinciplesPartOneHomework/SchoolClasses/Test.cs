namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    // Problem 1. School classes

    // We are given a school. In the school there are classes of students. Each class has a set of teachers. 
    // Each teacher teaches a set of disciplines. Students have name and unique class number. Classes have unique text identifier. 
    // Teachers have name. Disciplines have name, number of lectures and number of exercises. Both teachers and students are people. 
    // Students, classes, teachers and disciplines could have optional comments (free text block).
    // Your task is to identify the classes (in terms of OOP) and their attributes and operations, encapsulate their fields, 
    // define the class hierarchy and create a class diagram with Visual Studio.
    public class Test
    {
        public static void Main()
        {
            var firstDiscipline = new Discipline("HTML", 10, 10);
            var secondDiscipline = new Discipline("JavaScript", 25, 25);
            var thirdDiscipline = new Discipline("CSS", 15, 5);

            var fourthDiscipline = new Discipline("OOP", 15, 20);
            fourthDiscipline.AddComment("Best course ever");

            var fifthDiscipline = new Discipline("C#", 20, 25);

            Teacher firstTeacher = new Teacher("Ivancho", firstDiscipline, secondDiscipline, thirdDiscipline);
            Teacher secondTeacher = new Teacher("Marcheto", secondDiscipline, fourthDiscipline);

            Teacher thirdTeacher = new Teacher("Bojana", fifthDiscipline, thirdDiscipline);
            thirdTeacher.AddComment("Very lazy");

            Teacher fourthTeacher = new Teacher("Joreto", secondDiscipline, thirdDiscipline, fourthDiscipline, fifthDiscipline);
            Teacher fifthTeacher = new Teacher("Albena", fourthDiscipline, fifthDiscipline, secondDiscipline);

            Class classA = new Class("A", firstTeacher, secondTeacher, thirdTeacher);
            classA.AddComment("The best class of the academy");

            Class classB = new Class("B", fourthTeacher, fifthTeacher);

            School telerikAcademy = new School();
            telerikAcademy.AddClass(classA);
            telerikAcademy.AddClass(classB);
        }
    }
}
