namespace Gsm
{
    using System;
    using System.Collections.Generic;
    public class GSM
    {
        private const double PricePerMinute = 37;

        private static string iPhone4SInfo1 = "The iPhone 4S (retroactively stylized with a lowercase 's' as iPhone 4s as of September 2013) is a touchscreen-based smartphone developed, manufactured, and released by Apple Inc. It is the fifth generation of the iPhone, succeeding the iPhone 4 and preceding the iPhone 5. ";

        private Battery battery;
        private Display display;
        private string model;
        private string manufacturer;
        private double price;
        private string owner;
        private List<Calls> callHistory = new List<Calls>();

        public GSM()
        {

        }
        public GSM(string gsmModel, string gsmManufacturer)
        {
            this.Model = gsmModel;
            this.Manufacturer = gsmManufacturer;
        }

        public GSM(string gsmModel, string gsmManufacturer, double gsmPrice, string gsmOwner)
            : this(gsmModel, gsmManufacturer)
        {
            this.Price = gsmPrice;
            this.Owner = gsmOwner;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Field cannot be empty!");
                }
                this.model = value;
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
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Field cannot be empty!");
                }
                if (value.Length < 3)
                {
                    throw new ArgumentOutOfRangeException("Manufacturer's lenght should be longer than 3");
                }
                this.manufacturer = value;
            }
        }

        public double Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be negative");
                }
                this.price = value;
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
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty!");
                }
                if (value.Length < 3)
                {
                    throw new ArgumentException("Name's lenght should be longer than 3");
                }
                this.owner = value;
            }
        }


        public Battery GsmBattery
        {
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;
            }
        }

        public Display GsmDisplay
        {
            get
            {
                return this.display;
            }
            set
            {
                this.display = value;
            }
        }

        public string IPhone4SInfo
        {
            get
            {
                return iPhone4SInfo1;
            }
            set
            {
                iPhone4SInfo1 = value;
            }
        }

        public List<Calls> CallHistory
        {
            get
            {
                return this.callHistory;
            }
            set
            {
                this.callHistory = value;
            }
        }
        public void AddCall(Calls call)
        {
            this.CallHistory.Add(call);
        }

        public void DeleteCall(int durationOfCall)
        {
            foreach (var call in callHistory)
            {
                if (call.Duration == durationOfCall)
                {
                    this.CallHistory.Remove(call);
                    break;
                }
            }
        }

        public void ClearCalls()
        {
            this.CallHistory.Clear();
        }
        
        public override string ToString()
        {
            string model = Model.ToString();
            string manufacturer = Manufacturer.ToString();
            string price = Price.ToString();
            string owner = Owner.ToString();
            return "Model: " + model + "\r\nManufacturer: " + manufacturer + "\r\nPrice: " + price + "\r\nOwner: " + owner;
        }

        public double TotalPriceOfCalls()
        {
            double price = 0;
            foreach (var call in CallHistory)
            {
                if (call.Duration <= 60)
                {
                    price += PricePerMinute;
                    continue;
                }

                price += (double)call.Duration / 60 * PricePerMinute;
            }

            return price / 100;
        }
    }
}