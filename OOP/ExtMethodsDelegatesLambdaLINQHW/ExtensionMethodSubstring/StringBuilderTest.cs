namespace ExtensionMethodSubstring
{
    using System;
    using System.Text;

    public class StringBuilderTest
    {
        public static void Main()
        {
            StringBuilder test = new StringBuilder();
            test.Append("Telerik Academy");
            Console.WriteLine("Substring result: {0}", test.Substring(1, 5).ToString());
        }
    }
}
