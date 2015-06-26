namespace SchoolClasses.Models
{
    using System;

    public class Student : Person
    {
        private int classNumber;

        public Student(string firstNameOfPerson, string lastNameOfPerson, int classNumberOfStudent) 
            : base(firstNameOfPerson, lastNameOfPerson)
        {
            this.classNumber = classNumberOfStudent;
        }

        public int ClassNumber 
        {
            get
            {
                return this.classNumber;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Class number must be greater than 0");
                }
                this.classNumber = value;
            } 
        }

        public override string ToString()
        {
            return string.Format("First name: {0}\r\nLastName: {1}\r\nClassNumber: {2}", base.FirstName, base.LastName, ClassNumber);
        }
    }
}
