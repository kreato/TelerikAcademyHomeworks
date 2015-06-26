using System;
namespace Gsm
{
    public class CallHistoryTest
    {
        public void TestTheCallHistory()
        {
            GSM testCallHistory = new GSM();

            testCallHistory.AddCall(new Calls(new DateTime(2015, 03, 17), "+359876642834", 80));
            testCallHistory.AddCall(new Calls(new DateTime(2015, 03, 15), "+359886349830", 32));
            testCallHistory.AddCall(new Calls(new DateTime(2015, 03, 15), "+359895543831", 90));
            testCallHistory.AddCall(new Calls(new DateTime(2015, 03, 14), "+359879402535", 150));
            testCallHistory.AddCall(new Calls(new DateTime(2015, 03, 13), "+359883145884", 120));

            foreach (var call in testCallHistory.CallHistory)
            {
                Console.WriteLine(call);
            }

            Console.WriteLine();

            Console.WriteLine("Total price of calls: {0:F2}", testCallHistory.TotalPriceOfCalls());

            int longestCall = 0;
            foreach (var call in testCallHistory.CallHistory)
            {
                if (call.Duration > longestCall)
                {
                    longestCall = call.Duration;
                }
            }

            testCallHistory.DeleteCall(longestCall);

            Console.WriteLine("Total price of calls after removing the longest call: {0:F2}", testCallHistory.TotalPriceOfCalls());
            testCallHistory.ClearCalls();
        }
    }
}