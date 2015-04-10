namespace TimerUsingEvents
{
    using System;

    public class TimeChangeEventArgs : EventArgs
    {
        private int ticksLeft;

        public TimeChangeEventArgs(int ticksLeft)
        {
            this.TicksLeft = ticksLeft;
        }

        public int TicksLeft
        {
            get
            {
                return this.ticksLeft;
            }

            set
            {
                this.ticksLeft = value;
            }
        }
    }
}
