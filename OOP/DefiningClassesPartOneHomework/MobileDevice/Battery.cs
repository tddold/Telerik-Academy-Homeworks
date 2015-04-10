namespace MobileDevice
{
    using System;

    public class Battery
    {
        // Declaring fields
        private int? hoursIdle;
        private int? hoursTalk;

        private BatteryType batteryModel;

        // Declaring constructors
        public Battery()
        {
        }

        public Battery(BatteryType setType)
        {
        }
        
        public Battery(BatteryType setType, int? setHoursIdle = null)
        {
            this.HoursIdle = setHoursIdle;
        }

        public Battery(BatteryType setType, int? setHoursIdle, int? setHoursTalk = null)
            : this(setType, setHoursIdle)
        {
            this.HoursTalk = setHoursTalk;
        }

        // Declaring properties
        public BatteryType BatteryModel
        {
            get
            {
                return this.batteryModel;
            }

            set
            {
                this.batteryModel = value;
            }
        }

        public int? HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }

            set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException("Hours Idle can't be smaller than 0");
                }
                else
                {
                    this.hoursIdle = value;
                }
            }
        }

        public int? HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }

            set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException("Hours talk can't be smaller than 0");
                }
                else
                {
                    this.hoursTalk = value;
                }
            }
        }
    }
}
