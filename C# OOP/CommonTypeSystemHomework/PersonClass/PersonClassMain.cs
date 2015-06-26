namespace PersonClass
{
    using System;
    public class PersonClassMain
    {
        static void Main()
        {
            var person1 = new Person("Stefcho", 12);

            Console.WriteLine(person1);

            var person2 = new Person("Dracula");

            Console.WriteLine(person2);
        }
    }
}
