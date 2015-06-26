namespace SchoolClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Teacher : Person
    {
        private List<Discipline> disciplines;

        public Teacher(string firstNameOfPerson, string lastNameOfPerson, params Discipline[] teacherDiscipline) 
            : base(firstNameOfPerson, lastNameOfPerson)
        {
            this.disciplines = new List<Discipline>();
            this.disciplines.AddRange(teacherDiscipline);
        }

        public List<Discipline> Disciplines
        {
            get
            {
                return new List<Discipline>(this.disciplines);
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(string.Format("First name: {0}", base.FirstName));
            sb.AppendLine(string.Format("Last name: {0}",base.LastName));
            sb.AppendLine(string.Format("\r\nTeacher disciplines: \r\n{0}",string.Join("\r\n", Disciplines)));
            return sb.ToString();
        }
    }
}