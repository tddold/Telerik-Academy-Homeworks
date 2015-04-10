namespace SoftwareAcademy
{
    using System;
    using System.Text;

    public class OffsiteCourse : Course, ICourse, IOffsiteCourse
    {
        private const string TownNameNullExceptionErrorMessage = "Town name cannot be null or empty";
        private const string TownNameToStringFormat = "; Town={0}";

        private string town;

        public OffsiteCourse(string name, ITeacher teacher, string town)
            : base(name, teacher)
        {
            this.Town = town;
        }

        public string Town
        {
            get
            {
                return this.town;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(TownNameNullExceptionErrorMessage);
                }

                this.town = value;
            }
        }

        public override string ToString()
        {
            StringBuilder offsiteCourseToString = new StringBuilder(base.ToString());
            offsiteCourseToString.Append(string.Format(TownNameToStringFormat, this.Town));

            return offsiteCourseToString.ToString();
        }
    }
}
