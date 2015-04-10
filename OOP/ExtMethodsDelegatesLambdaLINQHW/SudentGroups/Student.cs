namespace SudentGroups
{
    using System;
    using System.Collections.Generic;

    public class Student
    {
        private string firstName;
        private string lastName;
        private int facultyNumber;
        private ulong telephone;
        private string email;
        private int groupNumber;

        private Group group;

        private List<int> marks;

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                else
                {
                    this.firstName = value;
                }
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                else
                {
                    this.lastName = value;
                }
            }
        }

        public int FN
        {
            get
            {
                return this.facultyNumber;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    this.facultyNumber = value;
                }
            }
        }

        public ulong Tel
        {
            get
            {
                return this.telephone;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    this.telephone = value;
                }
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                else
                {
                    this.email = value;
                }
            }
        }

        public List<int> Marks
        {
            get
            {
                return this.marks;
            }

            set
            {
                this.marks = value;
            }
        }

        public int GroupNumber
        {
            get
            {
                return this.groupNumber;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    this.groupNumber = value;
                }
            }
        }

        public Group Group
        {
            get { return this.group; }
            set { this.group = value; }
        }
    }
}
