namespace StudentsAndWorkers.Models
{
    using System;
    using System.Text;
    public class Worker : Human
    {
        private decimal workHoursPerDay;

        public Worker(string firstName, string lastName, decimal workerWeekSalary, decimal workerWorkHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = workerWeekSalary;
            this.WorkHoursPerDay = workerWorkHoursPerDay;
        }

        public decimal WeekSalary
        {
            get;
            private set;
        }

        public decimal WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            private set 
            {
                if (value < 4 || value > 12)
                {
                    throw new ArgumentException("Work hours per day must be between 4 and 12 ");
                }
                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour()
        {
            decimal result = (this.WeekSalary / 5) / this.WorkHoursPerDay;
            return result;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(string.Format("First name: {0}", base.FirstName));
            sb.AppendLine(string.Format("Last name: {0}", base.LastName));
            sb.AppendLine(string.Format("Money per hour: {0}", MoneyPerHour()));

            return sb.ToString();
        }
    }
}
