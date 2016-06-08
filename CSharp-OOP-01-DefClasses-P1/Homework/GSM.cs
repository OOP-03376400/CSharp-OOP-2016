namespace Homework
{
     using System;

    public class GSM
    {
        public string model;
        public string manufacturer;
        public int price;
        public string owner;
        public Battery battery;
        public Display display;

        public GSM(string manufacturer, string model )
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
        }

        public GSM(string manufacturer, string model, string owner)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.Owner = owner;
        }

        public GSM(string manufacturer, string model, string owner, int price, Battery battery, Display display)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.Owner = owner;
            this.Price = price;
            
        }

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
        public int Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public Battery Battery { get; set; }
        public Display Display { get; set; }

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
