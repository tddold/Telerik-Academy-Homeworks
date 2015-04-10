namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class Student : People, IComment
    {
        private int uniqueClassNumber;
        private IList<string> comments;

        public Student(string name, int classNumber)
        {
            this.Name = name;
            this.UniqueClassNumber = classNumber;
            this.comments = new List<string>();
        }

        public int UniqueClassNumber
        {
            get
            {
                return this.uniqueClassNumber;
            }

            set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException("The student ID cannot be a negative number");
                }
                else
                {
                    this.uniqueClassNumber = value;
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
