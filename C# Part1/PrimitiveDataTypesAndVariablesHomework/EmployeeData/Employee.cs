//Problem 10. Employee Data
//A marketing company wants to keep record of its employees. Each record would have the following characteristics:
//First name
//Last name
//Age (0...100)
//Gender (m or f)
//Personal ID number (e.g. 8306112507)
//Unique employee number (27560000…27569999)
//Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.
using System;
class Employee
{
    static void Main()
    {
        string firstName = "Jon";
        string lastName = "Lajoie";
        object fullName = firstName + " " + lastName;
        sbyte age = 34;
        char gender = '\u006D';
        long personalID = 8008210101;
        int employeeNum = 27565874;
        Console.WriteLine("This is the employee data of: {0}\nFirst name: {1}\nLast name: {2}\nAge: {3}\nGender: {4}\nPersonal ID nimber: {5}\nUnique employee number: {6}", fullName, firstName, lastName, age, gender, personalID, employeeNum);
    }
}