namespace StudentGroups
{
    using System;
    using System.Collections.Generic;

    public class Student
    {
        public Student(string firstName, string lastName, string fN, string tel, string email, int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FN = fN;
            this.Tel = tel;
            this.Email = email;
            this.GroupNumber = groupNumber;
        }
        public Student(string firstName, string lastName, string fN, string tel, string email, List<int> marks, int groupNumber)
            : this(firstName,lastName,fN,tel,email,groupNumber)
        {
            this.Marks = marks;
        }
        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public string FN { get; private set; }

        public string Tel { get; private set; }

        public string Email { get; private set; }

        public List<int> Marks { get; private set; }

        public int GroupNumber { get; private set; }

        public string MarksToString()
        {
            return string.Join(", ", this.Marks.ToArray());
        }

        public override string ToString()
        {
            return string.Format("FirstName: {0} LastName: {1}\r\nFN: {2} Tel: {3}\r\nEmail: {4} GroupNumber: {5}\r\n", FirstName.PadRight(21, ' '), LastName, FN.PadRight(28, ' '), Tel, Email.PadRight(25, ' '), GroupNumber);
        }
    }
}
