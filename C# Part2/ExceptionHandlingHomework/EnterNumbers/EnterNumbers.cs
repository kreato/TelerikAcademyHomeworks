namespace EnterNumbers
{
    using System;
    class EnterNumbers
    {
        static int min = - 1;
        static readonly int max = 101;
        static readonly int count = 10;
        static int ReadNumber()
        {
            Console.Write("Enter number in range {0} - {1}: ", min + 1, max - 1);
            int number = int.Parse(Console.ReadLine());
            if (number >= max || number <= min)
            {
                throw new ArgumentOutOfRangeException();
            }
            return number;
        }
        static void Main()
        {
            try
            {
                for (int i = 0; i < count; i++)
                {
                    min = ReadNumber();
                }
            }
            catch (FormatException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (ArgumentOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                Console.WriteLine("END");
            }
        }
    }
}
