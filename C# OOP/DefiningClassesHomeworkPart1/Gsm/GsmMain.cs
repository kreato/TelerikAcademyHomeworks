namespace Gsm
{
    using System;
    class GsmMain
    {
        static void Main()
        {
            Console.WriteLine(new string('=', 17) + "\r\nGSM class example\r\n" + new string('=', 17));
            GSM stupidGsm = new GSM("Galaxy Kles3", "Gnusmas", 700, "Acho");
            string gsmInfo = stupidGsm.ToString();
            Console.WriteLine(gsmInfo);

            Console.WriteLine(new string('=', 21) + "\r\nDisplay class example\r\n" + new string('=', 21));
            Display newDisplay = new Display(5.2, 16000000);
            Console.WriteLine("Display size: {0} inches\r\nDisplay colors: {1}", newDisplay.Size, newDisplay.NumberOfColors);

            Console.WriteLine(new string('=', 21) + "\r\nBattery class example\r\n" + new string('=', 21));
            Battery newBattery = new Battery(BatteryType.LiIon, 700, 600);
            Console.WriteLine("Battery model: {0}\r\nHours Idle: {1}\r\nHours Talk: {2}", newBattery.Model, newBattery.HoursIdle, newBattery.HoursTalk);

            Console.WriteLine(new string('=', 39) + "\r\nCall histroy and price of calls example\r\n" + new string('=', 39));
            GSM anotherTest = new GSM();
            anotherTest.AddCall(new Calls(new DateTime(2015, 3, 17), "+359873876678", 100));
            Console.WriteLine(anotherTest.CallHistory[0]);
            Console.WriteLine("Total price of calls: {0:F2}", anotherTest.TotalPriceOfCalls());

            Console.WriteLine(new string('=', 31) + "\r\nCall history test class example\r\n" + new string('=', 31));
            CallHistoryTest testHistrory = new CallHistoryTest();
            testHistrory.TestTheCallHistory();

            Console.WriteLine(new string('=', 22) + "\r\nGSM test class example\r\n" + new string('=', 22));
            GsmTest fewGsms = new GsmTest();
            fewGsms.CreateAFewGSMs(2);
        }
    }
}