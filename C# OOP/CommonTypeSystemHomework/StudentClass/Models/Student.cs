namespace StudentClass.Models
{
    using System;
    using System.Text;

    public class Student : ICloneable, IComparable<Student>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private int ssn;
        private string permanentAddress;
        private string mobilePhone;
        private string email;
        private int course;

        public Student(string firstName, string middleName, string lastName, int ssn, string address,
           string mobilePhone, string email, int course, University university, Faculty faculty, Specialty specialty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Ssn = ssn;
            this.Address = address;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Course = course;
            this.Specialty = specialty;
            this.University = university;
            this.Faculty = faculty;
        }


        public string FirstName
        {
            get { return this.firstName; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("First name data must not be null or empty");
                }

                this.firstName = value;
            }
        }

        public string MiddleName
        {
            get { return this.middleName; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Middle name data must not be null or empty");
                }

                this.middleName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Last name data must not be null or empty");
                }

                this.lastName = value;
            }
        }

        public int Ssn
        {
            get { return this.ssn; }
            private set
            {
                if (string.IsNullOrEmpty(value.ToString()))
                {
                    throw new ArgumentException("SSN data must not be null or empty");
                }

                this.ssn = value;
            }
        }

        public string Address
        {
            get { return this.permanentAddress; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Address data must not be null or empty");
                }

                this.permanentAddress = value;
            }
        }

        public string MobilePhone
        {
            get { return this.mobilePhone; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Mobile phone data must not be null or empty");
                }

                this.mobilePhone = value;
            }
        }

        public string Email
        {
            get { return this.email; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Email data must not be null or empty");
                }

                this.email = value;
            }
        }

        public int Course
        {
            get { return this.course; }
            private set
            {
                if (string.IsNullOrEmpty(value.ToString()))
                {
                    throw new ArgumentException("Course data must not be null or empty");
                }

                this.course = value;
            }
        }

        public University University { get; private set; }

        public Faculty Faculty { get; private set; }

        public Specialty Specialty { get; private set; }

        public override bool Equals(object obj)
        {
            var student = obj as Student;

            if (student == null)
            {
                return false;
            }

            if (this.Ssn == student.Ssn)
            {
                return true;
            }

            return false;
        }
        public object Clone()
        {
           return new Student(this.FirstName, this.MiddleName, this.LastName, this.Ssn, this.Address, this.MobilePhone,
                this.Email, this.Course, this.University, this.Faculty, this.Specialty);
        }

        public int CompareTo(Student other)
        {

            if (this.FirstName == other.FirstName)
            {
                return this.Ssn.CompareTo(other.Ssn);
            }
            return this.FirstName.CompareTo(other.FirstName);
        }

        public static bool operator ==(Student first, Student second)
        {
            return first.Equals(second);
        }

        public static bool operator !=(Student first, Student second)
        {
            return !(first.Equals(second));
        }

        public override int GetHashCode()
        {
            return this.Ssn.GetHashCode() ^ this.MobilePhone.GetHashCode();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(string.Format("Name: {0} {1} {2}", this.FirstName, this.MiddleName, this.LastName));
            sb.AppendLine("SSN: " + this.Ssn);
            sb.AppendLine("Address: " + this.Address);
            sb.AppendLine("Mobile Phone: " + this.MobilePhone);
            sb.AppendLine("Email: " + this.Email);
            sb.AppendLine("Course: " + this.Course);
            sb.AppendLine("University: " + this.University);
            sb.AppendLine("Faculty: " + this.Faculty);
            sb.AppendLine("Speciality: " + this.Specialty);

            return sb.ToString();
        }
    }
}
