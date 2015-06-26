namespace BankAccounts.Models
{
    using System;
    public class Customer
    {
        private string name;

        public Customer(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get { return this.name; }
            private set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name must not be null or empty!");
                }
                this.name = value; 
            }
        }
        
    }
}
