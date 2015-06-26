using System;

class PrintADeck
{
    static void Main()
    {
        for (int i = 0; i < 13; i++)
        {
            for (int j = 0; j < 1; j++)
            {
                switch (i)
                {
                    case 0: Console.Write("2 of spades, ");
                        Console.Write("2 of diamonds, ");
                        Console.Write("2 of hearts, ");
                        Console.Write("2 of clubs");
                        Console.WriteLine("\n");
                        break;

                    case 1: Console.Write("3 of spades, ");
                        Console.Write("3 of diamonds, ");
                        Console.Write("3 of hearts, ");
                        Console.Write("3 of clubs");
                        Console.WriteLine("\n");
                        break;

                    case 2: Console.Write("4 of spades, ");
                        Console.Write("4 of diamonds, ");
                        Console.Write("4 of hearts, ");
                        Console.Write("4 of clubs");
                        Console.WriteLine("\n");
                        break;

                    case 3: Console.Write("5 of spades, ");
                        Console.Write("5 of diamonds, ");
                        Console.Write("5 of hearts, ");
                        Console.Write("5 of clubs");
                        Console.WriteLine("\n");
                        break;

                    case 4: Console.Write("6 of spades, ");
                        Console.Write("6 of diamonds, ");
                        Console.Write("6 of hearts, ");
                        Console.Write("6 of clubs");
                        Console.WriteLine("\n");
                        break;

                    case 5: Console.Write("7 of spades, ");
                        Console.Write("7 of diamonds, ");
                        Console.Write("7 of hearts, ");
                        Console.Write("7 of clubs");
                        Console.WriteLine("\n");
                        break;

                    case 6: Console.Write("8 of spades, ");
                        Console.Write("8 of diamonds, ");
                        Console.Write("8 of hearts, ");
                        Console.Write("8 of clubs");
                        Console.WriteLine("\n");
                        break;

                    case 7: Console.Write("9 of spades, ");
                        Console.Write("9 of diamonds, ");
                        Console.Write("9 of hearts, ");
                        Console.Write("9 of clubs");
                        Console.WriteLine("\n");
                        break;

                    case 8: Console.Write("10 of spades, ");
                        Console.Write("10 of diamonds, ");
                        Console.Write("10 of hearts, ");
                        Console.Write("10 of clubs");
                        Console.WriteLine("\n");
                        break;

                    case 9: Console.Write("J of spades, ");
                        Console.Write("J of diamonds, ");
                        Console.Write("J of hearts, ");
                        Console.Write("J of clubs");
                        Console.WriteLine("\n");
                        break;

                    case 10: Console.Write("Q of spades, ");
                        Console.Write("Q of diamonds, ");
                        Console.Write("Q of hearts, ");
                        Console.Write("Q of clubs");
                        Console.WriteLine("\n");
                        break;

                    case 11: Console.Write("K of spades, ");
                        Console.Write("K of diamonds, ");
                        Console.Write("K of hearts, ");
                        Console.Write("K of clubs");
                        Console.WriteLine("\n");
                        break;

                    case 12: Console.Write("A of spades, ");
                        Console.Write("A of diamonds, ");
                        Console.Write("A of hearts, ");
                        Console.Write("A of clubs");
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}