namespace RangeExceptions
{
    using System;
    using System.Globalization;
    class RangeExceptionsMain
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            if (number < 1 || number > 100)
            {
                throw new InvalidRangeException<int>("Number must be between 1 and 100", 1, 100);
            }

            DateTime date = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);


            if (date < new DateTime(1980, 1, 1) || date > new DateTime(2013, 12, 31))
            {
                throw new InvalidRangeException<DateTime>("Date must be between 1.1.1980 and 31.12.2013", new DateTime(1980, 1, 1), new DateTime(2013, 12, 31));
            }
        }
    }
}
