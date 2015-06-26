//Problem 4. Age range
//Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
namespace AgeRange
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using FirstBeforeLast;
    public class AgeRangeMain
    {
        static void Main()
        {
            List<Student> students = new List<Student> 
            { 
                new Student("Pena", "Dunaprenova", 21),
                new Student("Yajo", "Sekvoev", 23),
                new Student("Velikan", "Stefanov", 18),
                new Student("Veselazasmyana", "Todorova", 20),
                new Student("Gospodinka", "Badjakova", 28),
                new Student("Gramofonka", "Nikolova", 29),
                new Student("Elena", "Pishtovkoleva", 38),
                new Student("Zayo", "Zaev", 40),
                new Student("Kapka", "Kashkavaldjieva", 19),
                new Student("Kasier", "Brankov", 22),
                new Student("Kinche", "Krivoshapkova", 34),
                new Student("Kirka", "Gradinarska", 24),
                new Student("Margarin", "Asenov", 45),
                new Student("Morena", "Pichurova", 21),
                new Student("Niva", "Pashova", 18),
                new Student("Peshka", "Shkembova", 23),
                new Student("Spartak", "Rimpopov", 29),
                new Student("Deflorina", "Zorova", 18)
            };
            var ageRange = from student in students
                                  where student.Age >= 18 && student.Age<=24
                                  select student;

            Console.WriteLine("All students with age between 18 and 24:");
            foreach (var student in ageRange)
            {
                Console.WriteLine(student);
            }
        }
    }
}