namespace MobileDevice
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class GSM
    {
        private const decimal PricePerMinute = 0.37M;

        // Declaring fields
        private static readonly GSM Iphone4S = new GSM("Iphone4S", "Apple", 1500M, "Ivancho", new Battery(BatteryType.LiIon), new Display(4, 160000));

        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;

        private Display displayCharacteristics;
        private Battery batteryCharacteristics;

        private List<Call> callHistory;

        // Declaring constructors
        public GSM()
        {
        }

        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.callHistory = new List<Call>();
        }

        public GSM(string model, string manufacturer, decimal? price = null)
            : this(model, manufacturer)
        {
            this.Price = price;
        }

        public GSM(string model, string manufacturer, decimal? price, string owner = null)
            : this(model, manufacturer, price)
        {
            this.Owner = owner;
        }

        public GSM(string model, string manufacturer, decimal? price, string owner, Battery battery)
            : this(model, manufacturer, price, owner)
        {
            this.BatteryCharacteristics = battery;
        }

        public GSM(string model, string manufacturer, decimal? price, string owner, Battery battery, Display display)
            : this(model, manufacturer, price, owner, battery)
        {
            this.DisplayCharacteristics = display;
        }

        // Declaring properties
        public static GSM IPhone4S
        {
            get
            {
                return Iphone4S;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("The model can't be null or empty");
                }
                else
                {
                    this.model = value;
                }
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("The manufacturer can't be null or empty");
                }
                else
                {
                    this.manufacturer = value;
                }
            }
        }

        public decimal? Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value <= 0)
                {
                    throw new InvalidOperationException("The price can't be equal or smaller than 0");
                }
                else
                {
                    this.price = value;
                }
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }

            set
            {
                this.owner = value;
            }
        }

        public Display DisplayCharacteristics
        {
            get
            {
                return this.displayCharacteristics;
            }

            set
            {
                this.displayCharacteristics = value;
            }
        }

        public Battery BatteryCharacteristics
        {
            get
            {
                return this.batteryCharacteristics;
            }

            set
            {
                this.batteryCharacteristics = value;
            }
        }

        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }
        }

        // Declaring methods
        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append("Mobile phone information:\n");
            result.Append(new string('*', 25));
            result.Append(string.Format("\nModel: {0}", this.Model));
            result.Append(string.Format("\nManufacturer: {0}", this.Manufacturer));
            result.Append(string.Format("\nPrice: {0:C2}", this.Price));
            result.Append(string.Format("\nOwner: {0}", this.Owner));
            result.Append(string.Format("\nBattery type: {0}", this.BatteryCharacteristics.BatteryModel));
            result.Append(string.Format("\nHours idle: {0}", this.BatteryCharacteristics.HoursIdle));
            result.Append(string.Format("\nHours talk: {0}", this.BatteryCharacteristics.HoursTalk));
            result.Append(string.Format("\nSize of screen: {0}", this.DisplayCharacteristics.SizeOfDisplay));
            result.Append(string.Format("\nNumber of colors: {0}\n", this.DisplayCharacteristics.NumberOfColors));
            result.Append(new string('*', 25));

            return result.ToString();
        }

        public void AddCalls(Call call)
        {
            this.callHistory.Add(call);
        }

        public void DeleteCalls(Call call)
        {
            this.callHistory.Remove(call);
        }

        public void ClearCalls()
        {
            this.callHistory.Clear();
        }

        public decimal CalculateCallsPrice()
        {
            decimal duration = 0;

            foreach (var item in this.callHistory)
            {
                duration += item.Duration;
            }

            return duration = (duration / 60) * PricePerMinute;
        }
    }
}
