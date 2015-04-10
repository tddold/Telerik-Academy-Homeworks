namespace SudentGroups
{
    using System;

    public class Group
    {
        private int groupNumber;
        private string departmentName;

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

        public string DepartmentName
        {
            get
            {
                return this.departmentName;
            }

            set
            {
                this.departmentName = value;
            }
        }
    }
}
