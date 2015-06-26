namespace AnimalHierarchy.Models
{
    using System;

    public class Frog : Animal
    {
        public Frog(string name, char sex, int age) : base(name, sex, age)
        {
        }
        public override void Sound()
        {
            base.Sound();
            Console.WriteLine("croak");
        }
    }
}
