namespace SchoolClasses.Models
{
    using System;
    public class Person
    {
        private string firstName;
        private string lastName;

        public Person(string firstNameOfPerson, string lastNameOfPerson)
        {
            this.FirstName = firstNameOfPerson;
            this.LastName = lastNameOfPerson;
        }

        public string FirstName 
        {
            get 
            {
                return this.firstName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First name cannot be null or empty");
                }
                this.firstName = value;
            }
        }

        public string LastName 
        {
            get 
            {
                return this.lastName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last name cannot be null or empty");
                }
                this.lastName = value;
            }
        }
        public override string ToString()
        {
            return string.Format("FirstName: {0}\r\nLastName: {1}",FirstName, LastName);
        }
    }
}
