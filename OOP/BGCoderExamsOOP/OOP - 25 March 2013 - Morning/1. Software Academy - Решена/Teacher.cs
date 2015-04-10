namespace SoftwareAcademy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Teacher : ITeacher
    {
        private const string NameNullExceptionErrorMessage = "Name cannot be null or empty";
        private const string TeacherNameToStringFormat = "Teacher: Name={0}";
        private const string CoursesNameToStringFormat = "; Courses=[{0}]";
        private const string CoursesStringJoinSeparator = ", ";
        private const int CoursesCountMinimumValue = 0;

        private string name;
        private ICollection<ICourse> courses;

        public Teacher(string name)
        {
            this.Name = name;
            this.courses = new List<ICourse>();
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
                    throw new ArgumentNullException(NameNullExceptionErrorMessage);
                }

                this.name = value;
            }
        }

        public void AddCourse(ICourse course)
        {
            this.courses.Add(course);
        }

        public override string ToString()
        {
            StringBuilder teacherToString = new StringBuilder();
            teacherToString.Append(string.Format(TeacherNameToStringFormat, this.Name));

            string allCoursesNames = string.Join(CoursesStringJoinSeparator, this.courses.Select(c => c.Name));

            if (this.courses.Count != CoursesCountMinimumValue)
            {
                teacherToString.Append(string.Format(CoursesNameToStringFormat, allCoursesNames));
            }

            return teacherToString.ToString();
        }
    }
}
