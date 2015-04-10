namespace MobileDevice
{
    using System;

    public class Call
    {
        // Declaring fields
        private DateTime timeOfCall;
        private string phoneNumber;
        private long duration;

        // Declaring constructors
        public Call(DateTime timeOfCall, string phoneNumber, long duration)
        {
            this.TimeOfCall = timeOfCall;
            this.PhoneNumber = phoneNumber;
            this.Duration = duration;
        }

        // Declaring properties
        public DateTime TimeOfCall
        {
            get
            {
                return this.timeOfCall;
            }

            set
            {
                this.timeOfCall = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }

            set
            {
                this.phoneNumber = value;
            }
        }

        public long Duration
        {
            get
            {
                return this.duration;
            }

            set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException("You must enter a number bigger than 0");
                }
                else
                {
                    this.duration = value;
                }
            }
        }
    }
}
