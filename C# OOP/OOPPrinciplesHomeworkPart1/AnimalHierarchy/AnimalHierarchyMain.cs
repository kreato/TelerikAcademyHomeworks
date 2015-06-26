namespace AnimalHierarchy
{
    using Models;
    using System;
    using System.Collections.Generic;
    public class AnimalHierarchyMain
    {
        static void Main()
        {
            List<Animal> cats = new List<Animal> 
            { 
                new Cat ("Puhcha", 'F', 3),
                new Cat ("Kotka", 'F', 4),
                new Cat ("Filt", 'M', 2)
            };

            List<Animal> dogs = new List<Animal> 
            { 
                new Dog ("Ondjichek", 'M', 5),
                new Dog ("Chiba", 'M', 4),
                new Dog ("Laika", 'F', 3)
            };

            List<Animal> frogs = new List<Animal> 
            { 
                new Frog ("Jaba", 'F', 6),
                new Frog ("Jaburana", 'F', 4),
                new Frog ("Gosho", 'M', 3)
            };

            List<Animal> kittens = new List<Animal>
            {
                new Kitten ("Ginka", 'F', 6),
                new Kitten ("Vena", 'F', 4),
                new Kitten ("Zara", 'F', 3)
            };

            List<Animal> tomcats = new List<Animal> 
            { 
                new Tomcat ("Pisan", 'M', 6),
                new Tomcat ("Tom", 'M', 4),
                new Tomcat ("Pesho", 'M', 3)
            };


            double averageAgeOfCats = Animal.AverageAge(cats);
            double averageAgeOfDogs = Animal.AverageAge(dogs);
            double averageAgeOfFrogs = Animal.AverageAge(frogs);
            double averageAgeOfKittens = Animal.AverageAge(kittens);
            double averageAgeOfTomcats = Animal.AverageAge(tomcats);

            Console.WriteLine("Average age of the cats: {0:F2}", averageAgeOfCats);
            Console.WriteLine("Average age of the dogs: {0:F2}", averageAgeOfDogs);
            Console.WriteLine("Average age of the frogs: {0:F2}", averageAgeOfFrogs);
            Console.WriteLine("Average age of the kittens: {0:F2}", averageAgeOfKittens);
            Console.WriteLine("Average age of the tomcats: {0:F2}", averageAgeOfTomcats);

            Console.WriteLine();
            foreach (var cat in cats)
            {
                cat.Sound();
            }
            Console.WriteLine();
            foreach (var dog in dogs)
            {
                dog.Sound();
            }

            Console.WriteLine();
            foreach (var frog in frogs)
            {
                frog.Sound();
            }
        }
    }
}
