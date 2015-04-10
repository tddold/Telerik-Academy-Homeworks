namespace MobileDevice
{
    using System;
    using System.Collections.Generic;

    public class GSMTest
    {
        public static void Main()
        {
            // Uncomment the Main() in GSMCallHistoryCall.cs and comment this to test
            var collection = new List<GSM>
            {
                //new GSM("Galaxy Note 4", "Samsung", 2000M, null, new Battery(), new Display()),
                new GSM("Galaxy S4", "Samsung", 1750M, "Maria", new Battery(BatteryType.NiMH), new Display(6, 160000)),
                new GSM("Nokia E72", "Nokia", null, null, new Battery(BatteryType.LiIon), new Display())
            };

            foreach (var item in collection)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine();
            }

            Console.WriteLine(GSM.IPhone4S);
        }
    }
}
