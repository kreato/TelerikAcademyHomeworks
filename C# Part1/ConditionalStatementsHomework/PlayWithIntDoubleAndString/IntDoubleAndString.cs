//Problem 9. Play with Int, Double and String
//Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends * at the end.
//Print the result at the console. Use switch statement.
//Example 1:
//program	                    user
//Please choose a type:	
//  1 --> int	
//  2 --> double	
//  3 --> string	            3
//Please enter a string:	    hello
//  hello*	
//Example 2:
//program	                    user
//Please choose a type:	
//  1 --> int	
//  2 --> double	            2
//  3 --> string	
//Please enter a double:	    1.5
//  2.5
using System;
class IntDoubleAndString
{
    static void Main()
    {
        Console.WriteLine("====================================");
        Console.WriteLine("\tPlease choose a type:");
        Console.WriteLine("====================================");
        Console.WriteLine("1 ==> int\r\n2 ==> double\r\n3 ==> string");
        int choice;
        bool check =  int.TryParse(Console.ReadLine(), out choice);
        if (check && choice >= 1 && choice <= 3)
        {
            switch (choice)
            {
                case 1: Console.Write("Please enter an int: ");
                    int number1;
                    bool isInt = int.TryParse(Console.ReadLine(), out number1);
                    if (isInt)
                    {
                        Console.WriteLine(number1 + 1);
                    }
                    else
                    {
                        Console.WriteLine("Not a valid int!");
                    }
                    break;
                case 2: Console.Write("Please enter a double: ");
                    double number2;
                    bool isDouble = double.TryParse(Console.ReadLine(), out number2);
                    if (isDouble)
                    {
                        Console.WriteLine(number2 + 1);
                    }
                    else
                    {
                        Console.WriteLine("Not a valid double!");
                    }
                    break;
                case 3: Console.Write("Please enter a string: ");
                    string text = Console.ReadLine();
                    Console.WriteLine(text + "*");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Not a valid choice!");
        }
    }
}