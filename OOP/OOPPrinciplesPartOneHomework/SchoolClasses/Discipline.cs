namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class Discipline : IComment
    {
        private string disciplineName;
        private int numberOfLectures;
        private int numberOfExercises;

        private IList<string> comments;

        public Discipline(string name, int numberOfLectures, int numberOfExercises)
        {
            this.DisciplineName = name;
            this.numberOfLectures = numberOfLectures;
            this.numberOfExercises = numberOfExercises;
            this.comments = new List<string>();
        }

        public string DisciplineName
        {
            get
            {
                return this.disciplineName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                else
                {
                    this.disciplineName = value;
                }
            }
        }

        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }

            set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException("The number of lectures cannot be a negative number");
                }
                else
                {
                    this.numberOfLectures = value;
                }
            }
        }

        public int NumberOfExercises
        {
            get
            {
                return this.numberOfExercises;
            }

            set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException("The number of exercises cannot be a negative number");
                }
                else
                {
                    this.numberOfExercises = value;
                }
            }
        }

        public string GetComments
        {
            get
            {
                return string.Join("/ ", this.comments);
            }
        }

        public void AddComment(string input)
        {
            this.comments.Add(input);
        }
    }
}
