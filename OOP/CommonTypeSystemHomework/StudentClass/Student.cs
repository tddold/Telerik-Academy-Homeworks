namespace StudentClass
{
    using System;
    using System.Text;

    public class Student : ICloneable, IComparable<Student>
    {
        // Declaring some fields
        private string firstName;
        private string middleName;
        private string lastName;
        private long socialSecurityNumber;
        private string permanentAddress;
        private string mobilePhone;
        private string email;
        private int course;
        private Specialty specialty;
        private University university;
        private Faculty faculty;

        // Declaring constructor
        public Student(string firstName, string middleName, string lastName, long ssn,  string address, string mobilePhone,
            string email, int course, Specialty specialty, University university, Faculty faculty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SocialSecurityNumber = ssn;
            this.PermanentAddress = address;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Course = course;
            this.Specialty = specialty;
            this.University = university;
            this.Faculty = faculty;
        }

        // Declaring properties
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

        public string MiddleName
        {
            get
            {
                return this.middleName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                else
                {
                    this.middleName = value;
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

        public long SocialSecurityNumber
        {
            get
            {
                return this.socialSecurityNumber;
            }

            set
            {
                if (value.ToString().Length != 10)
                {
                    throw new ArgumentException("Invalid social security number");
                }
                else
                {
                    this.socialSecurityNumber = value;
                }
            }
        }

        public string PermanentAddress
        {
            get
            {
                return this.permanentAddress;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                else
                {
                    this.permanentAddress = value;
                }
            }
        }

        public string MobilePhone
        {
            get
            {
                return this.mobilePhone;
            }

            set
            {
                if (value.Length != 10)
                {
                    throw new ArgumentException("Invalid mobile phone number");
                }
                else
                {
                    this.mobilePhone = value;
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
                if (!value.Contains("@"))
                {
                    throw new ArgumentException("Invalid email");
                }
                else
                {
                    this.email = value;
                }
            }
        }
        
        public int Course
        {
            get
            {
                return this.course;
            }

            set
            {
                if (value < 0 || value > 6)
                {
                    throw new ArgumentException("Invalid course number");
                }
                else
                {
                    this.course = value;
                }
            }
        }

        public Specialty Specialty
        {
            get
            {
                return this.specialty;
            }

            set
            {
                this.specialty = value;
            }
        }

        public University University
        {
            get
            {
                return this.university;
            }

            private set
            {
                this.university = value;
            }
        }

        public Faculty Faculty
        {
            get
            {
                return this.faculty;
            }

            private set
            {
                this.faculty = value;
            }
        }

        // Override
        public static bool operator ==(Student firstStudent, Student secondStudent)
        {
            return Student.Equals(firstStudent, secondStudent);
        }

        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            bool check = !Student.Equals(firstStudent, secondStudent);

            return check;
        }

        public override string ToString()
        {
            StringBuilder studentToString = new StringBuilder();

            studentToString.Append(new string('-', 50));
            studentToString.Append(string.Format("\nFirst Name: {0}\n", this.FirstName));
            studentToString.Append(string.Format("Middle Name: {0}\n", this.MiddleName));
            studentToString.Append(string.Format("Last Name: {0}\n", this.LastName));
            studentToString.Append(string.Format("SSN: {0}\n", this.SocialSecurityNumber));
            studentToString.Append(string.Format("Address: {0}\n", this.PermanentAddress));
            studentToString.Append(string.Format("Mobile phone: {0}\n", this.MobilePhone));
            studentToString.Append(string.Format("Email: {0}\n", this.Email));
            studentToString.Append(string.Format("Course: {0}\n", this.Course));
            studentToString.Append(string.Format("Specialty: {0}\n", this.Specialty));
            studentToString.Append(string.Format("University: {0}\n", this.University));
            studentToString.Append(string.Format("Faculty: {0}\n", this.Faculty));
            studentToString.Append(new string('-', 50));

            return studentToString.ToString();
        }

        public override bool Equals(object student)
        {
            var currentStudent = student as Student;

            if (currentStudent == null)
            {
                return false;
            }

            if (object.Equals(this.SocialSecurityNumber, currentStudent.SocialSecurityNumber))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() * this.SocialSecurityNumber.GetHashCode() ^ this.Email.GetHashCode();
        }

        public object Clone()
        {
            var result = this.MemberwiseClone();

            (result as Student).FirstName = this.FirstName;
            (result as Student).MiddleName = this.MiddleName;
            (result as Student).LastName = this.LastName;
            (result as Student).SocialSecurityNumber = this.SocialSecurityNumber;
            (result as Student).PermanentAddress = this.PermanentAddress;
            (result as Student).MobilePhone = this.MobilePhone;
            (result as Student).Email = this.Email;
            (result as Student).Course = this.Course;
            (result as Student).Specialty = this.Specialty;
            (result as Student).University = this.University;
            (result as Student).Faculty = this.Faculty;

            return result;
        }

        public int CompareTo(Student other)
        {
            if (this.FirstName != other.FirstName)
            {
                return this.FirstName.CompareTo(other.FirstName);
            }

            if (this.MiddleName != other.MiddleName)
            {
                return this.MiddleName.CompareTo(other.MiddleName);
            }

            if (this.LastName != other.LastName)
            {
                return this.LastName.CompareTo(other.LastName);
            }

            return this.SocialSecurityNumber.CompareTo(other.SocialSecurityNumber);
        }
    }
}
