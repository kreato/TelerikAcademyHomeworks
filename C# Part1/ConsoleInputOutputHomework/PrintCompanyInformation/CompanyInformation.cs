//Problem 2. Print Company Information
//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.
using System;
class CompanyInformation
{
    static void Main()
    {
        Console.Write("Enter Company name: ");
        string company = Console.ReadLine();
        Console.Write("Enter Company address: ");
        string address = Console.ReadLine();
        Console.Write("Enter Phone number (begin with +359): ");
        string phone = Console.ReadLine();
        Console.Write("Enter Fax number: ");
        int fax;
        bool isInt = int.TryParse(Console.ReadLine(), out fax);
        Console.Write("Enter Web site: ");
        string webSite = Console.ReadLine();
        Console.Write("Enter Manager first name: ");
        string firstName = Console.ReadLine();
        Console.Write("Enter Manager last name: ");
        string lastName = Console.ReadLine();
        Console.Write("Enter Manager age: ");
        byte age;
        bool isByte = byte.TryParse(Console.ReadLine(), out age);
        Console.Write("Enter Manager phone (begin with +359): ");
        string managerPhone = Console.ReadLine();
        if (isInt && isByte)
        {
            Console.WriteLine("\n\n\n{0}\nAddress: {1}\nTel. {2}\nFax: {3}\nWeb Site: {4}\nManager: {5} {6} (age: {7}, tel. {8})", company, address, phone, fax, webSite, firstName, lastName, age, managerPhone);
        }
        else
        {
            Console.WriteLine("Not a valid fax or age!");
        }
    }
}