namespace _02.BankAccounts
{
    using System;

    public abstract class Customer
    {
        private string name;

        public Customer(string name)
        {

        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name is needed!");
                }
                this.name = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Customer: {0}", this.Name);
        }
    }
}
