namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class Class : IComment
    {
        private string uniqueTextIdentifier;
        private IList<Teacher> teachers;
        private IList<string> comments;

        public Class(string uniqueTextIdentifier, params Teacher[] setOfTeachers)
        {
            this.UniqueTextIdentifier = uniqueTextIdentifier;
            this.comments = new List<string>();
            this.teachers = setOfTeachers;
        }

        public string UniqueTextIdentifier
        {
            get
            {
                return this.uniqueTextIdentifier;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The text identifier cannot be null or empty");
                }
                else
                {
                    this.uniqueTextIdentifier = value;
                }
            }
        }

        public string GetComments
        {
            get
            {
                return string.Join(", ", this.comments);
            }
        }

        public void AddComment(string input)
        {
            this.comments.Add(input);
        }
    }
}
