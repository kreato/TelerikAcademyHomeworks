namespace StudentClass
{
    using Models;
    using System;
    public class StudentClassMain
    {
        static void Main()
        {
            var student1 = new Student("Damyan","Ralev","Chernev",40867,"8 Kanarche Street", "+359888000000","damqn@abv.bg", 4 ,University.UniversityOfForestry, Faculty.FacultyOfVeterinaryMedicine, Specialty.VeterinaryMedicine);
            Console.WriteLine(student1.ToString());

            Console.WriteLine();
            var student2 = new Student("Boris", "Sharkov", "Romanov", 40860, "4 Marko Balabanov Street", "+359888888888", "boris@gmail.com", 2, University.SofiaUniversity, Faculty.FacultyOfBiology, Specialty.Biology);
            Console.WriteLine(student2.ToString());

            Console.WriteLine();
            var cloneStudent1 = student1.Clone();
            Console.WriteLine("First student's clone:\r\n{0}",cloneStudent1.ToString());

            Console.WriteLine(student1.CompareTo(student2));
        }
    }
}
