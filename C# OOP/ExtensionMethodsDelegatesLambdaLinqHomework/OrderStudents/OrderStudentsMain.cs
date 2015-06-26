//Problem 5. Order students
//Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order.
//Rewrite the same with LINQ.
namespace OrderStudents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using FirstBeforeLast;
    class OrderStudentsMain
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
            var orderStudentsLambda = students.OrderByDescending(x => x.FirstName)
                                          .ThenByDescending(x => x.LastName);
            Console.WriteLine("Extension Method:");
            Console.WriteLine("Sorted students by first name and last name in descending order:");
            foreach (var student in orderStudentsLambda)
            {
                Console.WriteLine(student);
            }
            var orderStudentsLinq =
            from student in students
            orderby student.FirstName descending, student.LastName descending
            select student;
            Console.WriteLine("LINQ:");
            Console.WriteLine("Sorted students by first name and last name in descending order:");
            foreach (var student in orderStudentsLinq)
            {
                Console.WriteLine(student);
            }
        }
    }
}
