namespace FirstBeforeLast
{
    using System;
    using System.Linq;
    public class Student
    {
        public Student(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public Student(string firstName, string lastName, int age) : this(firstName, lastName)
        {
            this.Age = age;
        }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public override string ToString()
        {
            return string.Format("First name: {0}\r\nLast name: {1}\r\nAge: {2}\r\n", FirstName, LastName, Age);
        }
    }
}
