namespace SoftwareAcademy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public abstract class Course : ICourse
    {
        private const string NameNullExceptionErrorMessage = "Name cannot be null or empty";
        private const string TeacherNullExceptionErrorMessage = "Teacher cannot be null";
        private const string CourseTypeStringFormat = "{0}: ";
        private const string CourseNameToStringFormat = "Name={0}";
        private const string CourseTeacherToStringFormat = "; Teacher={0}";
        private const string StringJoinElementSeparator = ", ";
        private const string CourseTopicsToStringFormat = "; Topics=[{0}]";
        private const int CourseCountMinimumValue = 0;

        private string name;
        private ITeacher teacher;
        private ICollection<string> topics;

        public Course(string name, ITeacher teacher)
        {
            this.Name = name;
            this.Teacher = teacher;
            this.topics = new List<string>();
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

        public ITeacher Teacher
        {
            get
            {
                return this.teacher;
            }

            set
            {
                this.teacher = value;
            }
        }

        public void AddTopic(string topic)
        {
            this.topics.Add(topic);
        }

        public override string ToString()
        {
            StringBuilder courseToString = new StringBuilder();

            courseToString.Append(string.Format(CourseTypeStringFormat, this.GetType().Name));
            courseToString.Append(string.Format(CourseNameToStringFormat, this.Name));

            if (this.Teacher != null)
            {
                courseToString.Append(string.Format(CourseTeacherToStringFormat, this.Teacher.Name));
            }

            string courseTopics = string.Join(StringJoinElementSeparator, this.topics.Select(tp => tp));

            if (this.topics.Count > CourseCountMinimumValue)
            {
                courseToString.Append(string.Format(CourseTopicsToStringFormat, courseTopics));
            }

            return courseToString.ToString();
        }
    }
}
