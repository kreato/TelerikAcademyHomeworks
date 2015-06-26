namespace AnimalHierarchy.Models
{
    using System;

    public class Cat : Animal
    {
        public Cat(string name, char sex, int age) 
            : base(name, sex, age)
        {
        }
        
        public override void Sound()
        {
            base.Sound();
            Console.WriteLine("meow");
        }

    }
}
