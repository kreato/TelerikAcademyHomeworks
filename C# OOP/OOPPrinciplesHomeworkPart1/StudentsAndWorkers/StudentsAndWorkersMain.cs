namespace StudentsAndWorkers
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class StudentsAndWorkersMain
    {
        static void Main()
        {
            List<Student> students = new List<Student>
            {
                new Student("Gosho","Goshev",8),
                new Student("Tosho","Toshev",1),
                new Student("Mitko","Mitev",2),
                new Student("Pesho","Peshev",12),
                new Student("Sasho","Sashev",8),
                new Student("Acho","Achev",7),
                new Student("Elka","Elkova",9),
                new Student("Elena","Elenova",4),
                new Student("Dimi","Dimova",5),
                new Student("Mimi","Mimova",3)
            };
            var sortedByGrade =
                from student in students
                orderby student.Grade ascending
                select student;
            Console.WriteLine(new string('*', 35));
            Console.WriteLine("Students sorted by Grade using LINQ");
            Console.WriteLine(new string('*', 35));
            foreach (var student in sortedByGrade)
            {
                Console.WriteLine(student);
            }

            ////////////////////////////////////////////////////////////////

            List<Worker> workers = new List<Worker>
            {
                new Worker("Branimir","Brankov", 200, 8),
                new Worker("Diliana","Deleva", 300, 12),
                new Worker("Ivan","Sharkov", 150, 4),
                new Worker("Ivo","Kolev", 500, 8),
                new Worker("Pepo","Slavov", 125, 4),
                new Worker("Hracho","Velev", 700, 8),
                new Worker("Stanka","Stanimirova", 250, 4),
                new Worker("Boryana","Belova", 325, 4),
                new Worker("Dragana","Fileva", 900, 12),
                new Worker("Pencho","Shilev", 110, 8)
            };

            var sortByMoneyPerHour =
                from worker in workers
                orderby worker.MoneyPerHour() ascending
                select worker;
            Console.WriteLine(new string('*', 43));
            Console.WriteLine("Workers sorted by Money per hour using LINQ");
            Console.WriteLine(new string('*', 43));
            foreach (var worker in sortByMoneyPerHour)
            {
                Console.WriteLine(worker);
            }

            ////////////////////////////////////////////////////////////////

            List<Human> studentsAndWorkers = new List<Human>();
            foreach (var student in students)
            {
                studentsAndWorkers.Add(student);
            }

            foreach (var worker in workers)
            {
                studentsAndWorkers.Add(worker);
            }

            var sortByName = studentsAndWorkers.OrderBy(x => x.FirstName).ThenBy(x => x.LastName);
            Console.WriteLine(new string('*', 73));
            Console.WriteLine("Students and workers sorted by First and Last name using extension method");
            Console.WriteLine(new string('*', 73));
            foreach (var studentAndWorker in sortByName)
            {
                Console.WriteLine(studentAndWorker);
            }
        }
    }
}
