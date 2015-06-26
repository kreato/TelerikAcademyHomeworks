namespace StudentsAndWorkers.Models
{
    using System;
    using System.Text;

    public class Student : Human
    {
        private int grade;

        public Student(string firstName, string lastName, int studentGrade) : base(firstName, lastName)
        {
            this.Grade = studentGrade;
        }

        public int Grade 
        {
            get 
            {
                return this.grade;
            }
            private set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Grade must be between 1 and 12");
                }
                this.grade = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(string.Format("First name: {0}",base.FirstName));
            sb.AppendLine(string.Format("Last name: {0}", base.LastName));
            sb.AppendLine(string.Format("Grade: {0}", this.Grade));

            return sb.ToString();
        }
    }
}
