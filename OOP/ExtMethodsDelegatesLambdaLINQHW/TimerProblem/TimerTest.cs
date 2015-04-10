namespace TimerProblem
{
    using System;

    public class TimerTest
    {
        public static void Main()
        {
            Timer timer = new Timer(1, 10);

            Console.WriteLine("Houston we have a problem...");
            Console.WriteLine("The pilot is a female... {0} seconds to impact", timer.NumberOfTicks);

            timer.Methods = delegate
            {
                Console.WriteLine("{0}", timer.NumberOfTicks + 1 - timer.Counter);
            };

            timer.RunTimer();

            Console.WriteLine("BOOOM!!!");
        }
    }
}
