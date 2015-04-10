namespace Attributes
{
    using System;

    [Version("1.13")]
    public class TestClass
    {
        public TestClass(string firstName, string secondName)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
        }

        public string FirstName { get; set; }

        public string SecondName { get; set; }
    }
}
