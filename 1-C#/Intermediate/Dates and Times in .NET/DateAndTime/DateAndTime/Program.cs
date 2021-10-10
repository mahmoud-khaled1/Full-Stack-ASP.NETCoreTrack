using System;
using System.IO;
using System.Linq;
using System.Globalization;
namespace DateAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileResult = File.ReadAllLines("StockData.csv");
            foreach (var line in fileResult.Skip(1))
            {
                var segment = line.Split(',');
                var tradeData = DateTime.Parse(segment[1]);
                Console.WriteLine(tradeData.ToLongDateString());
            }

            Console.WriteLine("------------------");

            var dataTimeNow = DateTime.Now;
            Console.WriteLine(dataTimeNow);
            
            // prevous Time is time in our local system in my county 
            // we can get Time of Tokyo country by using my country time .
            TimeZoneInfo TokyoTimeZone = 
                TimeZoneInfo.FindSystemTimeZoneById("Tokyo Standard Time");

            var tokyoTime = TimeZoneInfo.ConvertTime(dataTimeNow, TokyoTimeZone);
            Console.WriteLine(tokyoTime);

            Console.WriteLine("------------------");

            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTimeOffset.Now);

            Console.WriteLine("------------------");

            //Parse String To DateTime 
            var date = "9/10/2019 10:00:00 PM";
            var parsedDate = DateTime.ParseExact(date, "M/d/yyyy h:mm:ss tt",
                CultureInfo.InvariantCulture);

            Console.WriteLine(parsedDate);
        }
    }
}
