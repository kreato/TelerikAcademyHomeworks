namespace Timer
{
    using System;
    using System.Threading;
    class TimerMain
    {
        static void Main()
        {

            Timer t = new Timer(500, delegate() { Console.Beep(); Console.WriteLine("Beep"); ; });
            t.Start();
            Thread.Sleep(10000);
            t.Stop();
        }
    }
}