//Problem 15.* Age after 10 Years
//Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.
using System;

class AgeCalculator
    {
        static void Main()
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter your birthdate (dd.mm.yyyy): ");
                    DateTime birthDate = DateTime.Parse(Console.ReadLine());

                    int days = (DateTime.Now.Year * 365 + DateTime.Now.DayOfYear) - (birthDate.Year * 365 + birthDate.DayOfYear);
                    int years = days / 365;
                    int future = years + 10;
                    string result = (days >= 365) ? "Your age: " + years + " years" : "Your age: " + days + " days";
                    string result2 = (days >= 365) ? "Your age after 10 years: " + future + " years" : "Your Age: " + days + " days";
                    Console.WriteLine(result);
                    Console.WriteLine(result2);
                }
                catch
                {
                    Console.WriteLine("You have entered an invalid date.\n");
                }

                Console.WriteLine("Exit? (y/n)");
                string userValue = Console.ReadLine();

                if (userValue == "y")
                {
                    Environment.Exit(0);
                }
            }
        }
    }
