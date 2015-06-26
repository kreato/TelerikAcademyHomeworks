namespace ExtractStudentsByEmail
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using StudentGroups;
    class ExtractStudentsByEmailMain
    {
        static void Main()
        {
            List<Student> students = new List<Student>
            {
                new Student("Pena", "Dunaprenova", "40862","+35929656565","pena@abv.bg", 1),
                new Student("Yajo", "Sekvoev", "40863","+35949659305","yajo@abv.bg", 1),
                new Student("Velikan", "Stefanov", "40864","+35929659405","velican@gmail.com", 2),
                new Student("Veselazasmyana", "Todorova", "40865","+35949930507","veselazasmyana@yahoo.com", 2),
                new Student("Gospodinka", "Badjakova", "40866","+35949653333","gospodinka@abv.bg", 2),
                new Student("Gramofonka", "Nikolova", "40867","+35949654444","gramofonka@yahoo.com", 1),
                new Student("Elena", "Pishtovkoleva", "40868","+35949656565","elena@yahoo.com", 2),
                new Student("Zayo", "Zaev", "40869","+35929655555","zayo@abv.bg", 1),
                new Student("Kapka", "Kashkavaldjieva", "40870","+35949656666","kapka@gmail.com", 1),
                new Student("Kasier", "Brankov", "40871","+35929657777","kasier@abv.bg", 1),
                new Student("Kinche", "Krivoshapkova", "40872","+35929658888","kinche@gmail.com", 2),
                new Student("Kirka", "Gradinarska", "40873","+35929659999","kirka@yahoo.com", 2),
                new Student("Margarin", "Asenov", "40874","+35929651010","margarin@abv.bg", 1),
                new Student("Morena", "Pichurova", "40875","+35929651111","morena@gmail.com", 1),
                new Student("Niva", "Pashova", "40876","+35949652222","niva@abv.bg", 2),
                new Student("Peshka", "Shkembova", "40877","+35949651212","peshka@yahoo.com", 2),
                new Student("Spartak", "Rimpopov", "40878","+35929651313","spartak@yahoo.com", 2),
                new Student("Deflorina", "Zorova", "40879","+35929651414","deflorina@abv.bg", 1)
            };
            var abvEmails =
                from student in students
                where student.Email.Contains("abv.bg")
                select student;
            Console.WriteLine("Students with email in ABV:");
            foreach (var student in abvEmails)
            {
                Console.WriteLine(student);
            }
        }
    }
}
