namespace SchoolClasses
{
    using System.Collections.Generic;

    public class School
    {
        private IList<Class> classOfStudents;

        public School()
        {
            this.classOfStudents = new List<Class>();
        }

        // Adding new class of students
        public void AddClass(params Class[] newClass)
        {
            foreach (var item in newClass)
            {
                this.classOfStudents.Add(item);
            }
        }
    }
}
