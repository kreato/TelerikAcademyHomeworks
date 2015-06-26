namespace Gsm
{
    using System;
    using System.Collections.Generic;
    public class GsmTest
    {
        public void CreateAFewGSMs(int numOfGsms)
        {
            GSM[] someGsms = new GSM[numOfGsms];
            for (int i = 0; i < numOfGsms; i++)
            {
                someGsms[i] = new GSM();
                Console.Write("Enter model for GSM number {0}: ", i + 1);
                someGsms[i].Model = Console.ReadLine();
                Console.Write("Enter manufacturer for GSM number {0}: ", i + 1);
                someGsms[i].Manufacturer = Console.ReadLine();
                Console.Write("Enter owner for GSM number {0}: ", i + 1);
                someGsms[i].Owner = Console.ReadLine();
                Console.Write("Enter price for GSM number {0}: ", i + 1);
                someGsms[i].Price = double.Parse(Console.ReadLine());
            }
            foreach (var gsm in someGsms)
            {
                Console.WriteLine("Model: {0}\r\nManufacturer: {1}\r\nOwner: {2}\r\nPrice: {3}", gsm.Model, gsm.Manufacturer, gsm.Owner, gsm.Price);
            }
            GSM iPhoneInfo = new GSM();
            Console.WriteLine(iPhoneInfo.IPhone4SInfo);
        }
    }
}
