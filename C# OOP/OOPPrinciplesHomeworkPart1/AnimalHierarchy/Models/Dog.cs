namespace AnimalHierarchy.Models
{
    using System;

    public class Dog : Animal
    {
        public Dog(string name, char sex, int age) : base(name, sex, age)
        {
        }
        public override void Sound()
        {
            base.Sound();
            Console.WriteLine("woof woof");
        }
    }
}
