namespace AnimalHierarchy.Models
{
    using System;

    public class Kitten : Cat
    {
        public Kitten(string name, char sex, int age)
            : base(name, sex, age)
        {
            if (base.Sex == 'M')
            {
                throw new ArgumentException("Kitten must be Female");
            }
        }
    }
}