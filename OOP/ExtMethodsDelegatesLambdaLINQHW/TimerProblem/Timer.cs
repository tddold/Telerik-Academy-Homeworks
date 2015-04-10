namespace TimerProblem
{
    using System;
    using System.Threading;

    // Problem 7. Timer

    // Using delegates write a class Timer that can execute certain method at each t seconds.
    public class Timer
    {
        private MethodsToExecute methods;
        private int interval;
        private int numberOfTicks;
        private int counter;

        public Timer(int interval, int numberOfTicks)
        {
            this.Interval = interval;
            this.NumberOfTicks = numberOfTicks;
            this.counter = 0;
        }

        public delegate void MethodsToExecute();

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

        public MethodsToExecute Methods
        {
            get
            {
                return this.methods;
            }

            set
            {
                this.methods = value;
            }
        }

        public int Counter
        {
            get
            {
                return this.counter;
            }

            private set
            {
            }
        }

        public void RunTimer()
        {
            while (this.counter <= this.numberOfTicks)
            {
                Thread.Sleep(this.interval * 1000);
                this.counter++;
                this.Methods();
            }
        }
    }
}
