namespace SchoolClasses.Models
{
    using System.Collections.Generic;

    public class School
    {
        private List<Class> classes;

        public School(params Class[] classes)
        {
            this.classes = new List<Class>();
            this.classes.AddRange(classes);
        }

        public List<Class> Classes
        {
            get 
            { 
                return new List<Class>(this.classes); 
            }
            private set
            {
                this.classes = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Classes: {0}",string.Join("\r\n",Classes));
        }
    }
}
