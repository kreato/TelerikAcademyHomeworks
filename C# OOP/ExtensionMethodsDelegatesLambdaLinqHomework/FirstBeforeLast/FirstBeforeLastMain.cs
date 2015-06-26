//Problem 3. First before last
//Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
//Use LINQ query operators.
namespace FirstBeforeLast
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class FirstBeforeLastMain
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
            var firstBeforeLast = from student in students
                                  where student.FirstName.CompareTo(student.LastName) < 0
                                  select student;

            Console.WriteLine("All students whose first name is before its last name alphabetically:");
            foreach (var student in firstBeforeLast)
            {
                Console.WriteLine(student);
            }
        }
    }
}
