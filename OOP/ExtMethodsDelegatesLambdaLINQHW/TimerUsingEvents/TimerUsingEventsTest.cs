namespace TimerUsingEvents
{
    using System;

    public class TimerUsingEventsTest
    {
        public static void CountTime(object sender, TimeChangeEventArgs eventArgs)
        {
            Console.WriteLine("{0}", eventArgs.TicksLeft);
        }

        public static void Main()
        {
            Timer timer = new Timer(1, 10);

            Console.WriteLine("Houston we have a problem... part 2");
            Console.WriteLine("The pilots are a monkeys... {0} seconds to impact", timer.NumberOfTicks);

            timer.TimeChanged += CountTime;

            timer.RunTimer();

            Console.WriteLine("BOOOOOM!!!!");
        }
    }
}
