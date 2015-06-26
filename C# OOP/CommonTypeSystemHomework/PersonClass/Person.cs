namespace PersonClass
{
    using System;
    using System.Text;
    public class Person
    {
        private string name;
        private int? age;

        public Person(string name)
        {
            this.Name = name;
        }

        public Person(string name, byte age)
            : this(name)
        {
            this.Age = age;
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name data must not be null or empty");
                }

                this.name = value;
            }
        }

        public int? Age
        {
            get { return this.age; }
            private set{ this.age = value; }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(string.Format("Name: {0}", this.Name));

            if (this.Age == null)
            {
                sb.AppendLine("Age: Not specified");
            }
            else
            {
                sb.AppendLine(string.Format("Age: {0}", this.Age));
            }

            return sb.ToString();
        }
    }
}
