namespace AnimalHierarchy.Models
{
    using Interface;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public abstract class Animal : ISound
    {
        private string name;
        private char sex;
        private int age;

        public Animal(string name, char sex, int age)
        {
            this.Name = name;
            this.Sex = sex;
            this.Age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty");
                }
                this.name = value;
            }
        }

        public char Sex
        {
            get
            {
                return this.sex;
            }
            protected set
            {
                if (value != 'M' && value != 'F')
                {
                    throw new ArgumentException("Sex must be M for Male or F for Female");
                }
                this.sex = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                if (value < 0 || value > 20)
                {
                    throw new ArgumentOutOfRangeException("Age must be between 0 and 20 years");
                }
                this.age = value;
            }
        }
        public virtual void Sound()
        {
            Console.Write("{0} said: ", this.Name);
        }

        public static double AverageAge(List<Animal> animals)
        {
            return animals.Average(x => x.Age);
        }
    }
}
