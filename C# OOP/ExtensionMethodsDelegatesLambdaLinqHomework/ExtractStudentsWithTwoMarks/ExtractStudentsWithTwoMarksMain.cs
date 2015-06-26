namespace ExtractStudentsWithTwoMarks
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using StudentGroups;
    class ExtractStudentsWithTwoMarksMain
    {
        static void Main()
        {
            List<Student> students = new List<Student>
            {
                new Student("Pena", "Dunaprenova", "40862","+35929656565","pena@abv.bg",new List<int>{2,5,5,6,6,3,4,6}, 1),
                new Student("Yajo", "Sekvoev", "40863","+35949659305","yajo@abv.bg",new List<int>{2,4,}, 1),
                new Student("Velikan", "Stefanov", "40864","+35929659405","velican@gmail.com",new List<int>{6,6,6,5,6,6,6,5}, 2),
                new Student("Veselazasmyana", "Todorova", "40865","+35949930507","veselazasmyana@yahoo.com",new List<int>{2,2,2,2,2,3,3,2}, 2),
                new Student("Gospodinka", "Badjakova", "40866","+35949653333","gospodinka@abv.bg",new List<int>{6,4,5,6,6,3,4,6}, 2),
                new Student("Gramofonka", "Nikolova", "40867","+35949654444","gramofonka@yahoo.com",new List<int>{4,3}, 1),
                new Student("Elena", "Pishtovkoleva", "40868","+35949656565","elena@yahoo.com",new List<int>{6,2,6,2,6,2,6,2}, 2),
                new Student("Zayo", "Zaev", "40869","+35929655555","zayo@abv.bg",new List<int>{2,2,2,2,2,2,2,2}, 1),
                new Student("Kapka", "Kashkavaldjieva", "40870","+35949656666","kapka@gmail.com",new List<int>{6,6,6,6,6,6,6,2}, 1),
                new Student("Kasier", "Brankov", "40871","+35929657777","kasier@abv.bg",new List<int>{3,3,3,2,2,2,2,6}, 1),
                new Student("Kinche", "Krivoshapkova", "40872","+35929658888","kinche@gmail.com",new List<int>{5,5,5,5,4,5,5,5}, 2),
                new Student("Kirka", "Gradinarska", "40873","+35929659999","kirka@yahoo.com",new List<int>{2,3}, 2),
                new Student("Margarin", "Asenov", "40874","+35929651010","margarin@abv.bg",new List<int>{3,3,6,6,6,6,6,6}, 1),
                new Student("Morena", "Pichurova", "40875","+35929651111","morena@gmail.com",new List<int>{2,4,5,2,2,6,4,2}, 1),
                new Student("Niva", "Pashova", "40876","+35949652222","niva@abv.bg",new List<int>{2,2,2,2,2,3,4,2}, 2),
                new Student("Peshka", "Shkembova", "40877","+35949651212","peshka@yahoo.com",new List<int>{2,4,5,2,2,3,4,2}, 2),
                new Student("Spartak", "Rimpopov", "40878","+35929651313","spartak@yahoo.com",new List<int>{2,2,2,2,2,2,2,2}, 2),
                new Student("Deflorina", "Zorova", "40879","+35929651414","deflorina@abv.bg",new List<int>{6,6,6,6,6,6,6,6}, 1)
            };
            var studentsWith2Marks = from student in students
                                     where student.Marks.Count == 2
                                     select new { FirstName = student.FirstName, LastName = student.LastName, Marks = student.MarksToString() };
            Console.WriteLine("Students with two marks: ");
            foreach (var student in studentsWith2Marks)
            {
                Console.WriteLine("FirstName: {0}\r\nLastName: {1}\r\nMarks: {2}\r\n", student.FirstName, student.LastName, student.Marks);
            }
        }
    }
}
