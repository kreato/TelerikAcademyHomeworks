namespace SchoolClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Class
    {
        private string textIdentifier;
        private List<Teacher> teachers;

        public Class(string classTextIdentifier, params Teacher[] classTeacher)
        {
            this.TextIdentifier = classTextIdentifier;
            this.teachers = new List<Teacher>();
            this.teachers.AddRange(classTeacher);
        }

        public string TextIdentifier 
        {
            get 
            { 
                return this.textIdentifier; 
            }
            private set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Class must have text identifier");
                }
                this.textIdentifier = value;
            }
        }

        public List<Teacher> Teachers 
        {
            get { return new List<Teacher>(this.teachers); }
            private set { this.teachers = value; }
        }

        public string Comment { get; set; }

        public string AddComment(string comment)
        {
            return this.Comment = comment;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(string.Format("Class:{0}", TextIdentifier));
            sb.AppendLine(string.Format("Comment: {0}", Comment));
            sb.AppendLine(string.Format("\r\nTeachers: \r\n{0}", string.Join("\r\n", Teachers)));
            return sb.ToString();
        }
    }
}
