namespace Attributes
{
    using System;

    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class |
        AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Method,
        AllowMultiple = false)]

    public class VersionAttribute : Attribute
    {
        public VersionAttribute(string version)
        {
            this.Version = version;
        }

        public string Version { get; private set; }

        public static void Main()
        {
            Type type = typeof(TestClass);

            object[] a = type.GetCustomAttributes(false);

            foreach (VersionAttribute item in a)
            {
                Console.WriteLine("Version: {0}", item.Version);
            }
        }
    }
}
