namespace AnimalHierarchy.Models
{
    using System;

    public class Tomcat : Cat
    {
        public Tomcat(string name, char sex, int age) : base(name, sex, age)
        {
            if (base.Sex == 'F')
            {
                throw new ArgumentException("Tomcat must be Male");
            }
        }
    }
}
