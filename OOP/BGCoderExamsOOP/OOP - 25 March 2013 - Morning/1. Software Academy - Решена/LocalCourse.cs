namespace SoftwareAcademy
{
    using System;
    using System.Text;

    public class LocalCourse : Course, ICourse, ILocalCourse
    {
        private const string LabNameNullExceptionErrorMessage = "Lab name cannot be null or empty";
        private const string LabNameToStringFormat = "; Lab={0}";

        private string lab;

        public LocalCourse(string name, ITeacher teacher, string lab)
            : base(name, teacher)
        {
            this.Lab = lab;
        }

        public string Lab
        {
            get
            {
                return this.lab;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(LabNameNullExceptionErrorMessage);
                }

                this.lab = value;
            }
        }

        public override string ToString()
        {
            StringBuilder localCourseToString = new StringBuilder(base.ToString());
            localCourseToString.Append(string.Format(LabNameToStringFormat, this.Lab));

            return localCourseToString.ToString();
        }
    }
}
