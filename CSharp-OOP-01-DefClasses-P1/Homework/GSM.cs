namespace Homework
{
     using System;

    public class GSM
    {
        private const string defaultOwner = null;

        public string model;
        public string manufacturer;
        public int? price;
        public string owner;
        public Battery battery;
        public Display display;

        private static readonly GSM iPhone4s =
            new GSM("Apple", "iPhone4s", defaultOwner, null, new Battery(), new Display());

        //constructors
        public GSM(string manufacturer, string model, string owner, int? price, Battery battery, Display display)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.Owner = owner;
            this.Price = price;
            this.battery = battery;
            this.display = display;

        }

        public GSM(string manufacturer, string model )
            :this(manufacturer, model, defaultOwner, null /*price*/, new Battery(), new Display())
        {
        }

        public GSM(string owner)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.Owner = owner;
        }

        //properties
        public string Model 
        { 
            get { return this.model; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Model cannot be null");
                }
                this.model = value; }
        }

        private string Manufacturer
        {
            get { return this.manufacturer; }
            set {
                    if (String.IsNullOrEmpty(value))
                    {
                        throw new ArgumentException("Manufacturer cannot be null");
                    }
                    this.manufacturer = value; 
                }
        }

        public string Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }

        public int? Price
        {
            get { return this.price; }
            set 
            {
                if (value<0)
                {
                    throw new ArgumentOutOfRangeException("The price cannot be negative");
                }
                this.price = value; 
            }
        }

        public Battery Battery { get; set; }

        public Display Display { get; set; }

        public static GSM IPhone4s
        {
            get { return iPhone4s; }
        }

        public override string ToString()
        {
            return "---   ---   ---   ---   ---\n"
                + this.Manufacturer + " " + this.Model
                + "\nOwner: " + this.Owner
                + "\nPrice: " + this.Price
                + "\nBattery: " + this.Battery
                + "\nDisplay: " + this.Display 
                + "\n---   ---   ---   ---   ---";
        }
        
    }
}
