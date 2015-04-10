namespace TimerUsingEvents
{
    using System;
    using System.Threading;

    // Problem 8.* Events

    // Read in MSDN about the keyword event in C# and how to publish events.
    // Re-implement the above using .NET events and following the best practices.
    public class Timer
    {
        private int interval;
        private int numberOfTicks;

        public Timer(int interval, int numberOfTicks)
        {
            this.Interval = interval;
            this.NumberOfTicks = numberOfTicks;
        }

        public delegate void TimeChangeEventHandler(object sender, TimeChangeEventArgs eventArgs);

        public event TimeChangeEventHandler TimeChanged;

        public int Interval
        {
            get
            {
                return this.interval;
            }

            set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException("The interval must be a positive number");
                }
                else
                {
                    this.interval = value;
                }
            }
        }

        public int NumberOfTicks
        {
            get
            {
                return this.numberOfTicks;
            }

            set
            {
                if (value < 1)
                {
                    throw new InvalidOperationException("Ticks must be at least 1");
                }
                else
                {
                    this.numberOfTicks = value;
                }
            }
        }

        public void RunTimer()
        {
            int counter = this.numberOfTicks;

            while (counter > 0)
            {
                Thread.Sleep(this.interval * 1000);
                counter--;
                this.OnTimeChanged(counter);
            }
        }

        protected void OnTimeChanged(int tick)
        {
            if (this.TimeChanged != null)
            {
                TimeChangeEventArgs eventArgs = new TimeChangeEventArgs(tick);
                this.TimeChanged(this, eventArgs);
            }
        }
    }
}
