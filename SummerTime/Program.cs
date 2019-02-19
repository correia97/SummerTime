using System;

namespace SummerTime
{
    class Program
    {
        static void Main(string[] args)
        {
            var thisTime = DateTime.Now;
            var tst = TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time");
            var isDaylight = tst.IsDaylightSavingTime(thisTime);


            Console.WriteLine($"Today ({thisTime.ToShortDateString()} ) is summerTime ? " + (isDaylight ? "Yes!" : "No!"));


            thisTime = new DateTime(2019,02,16);
            tst = TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time");
            isDaylight = tst.IsDaylightSavingTime(thisTime);

            Console.WriteLine($"{thisTime.ToShortDateString()} is summerTime ? " + (isDaylight ? "Yes!" : "No!"));

            Console.ReadKey();
        }
    }
}
