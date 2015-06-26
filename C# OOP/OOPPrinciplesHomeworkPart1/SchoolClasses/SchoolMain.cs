namespace SchoolClasses
{
    using Models;
    using System;
    public class SchoolMain
    {
        static void Main()
        {
            Discipline historyOfFilm = new Discipline("History of Film", 10, 15);
            historyOfFilm.AddComment(@"Learn the history of film");

            Discipline filmDirecting = new Discipline("Film Directing",15,20);
            filmDirecting.AddComment(@"Learn fundamentals of film directing");

            Teacher pedro = new Teacher("Pedro", "Almodovar", new [] { historyOfFilm, filmDirecting });

            Class newClass = new Class("8B", pedro);
            newClass.AddComment("Otlichnici");
            Console.WriteLine(newClass.ToString());

            Console.WriteLine("Students:");
            Student gosho = new Student("Gosho", "Goshev", 1);
            Console.WriteLine(gosho);
        }
    }
}
