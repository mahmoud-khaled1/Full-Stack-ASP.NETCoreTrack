using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Cars;

namespace Filtering_Ordering_Projecting
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = ProcessFile("fuel.csv");
            foreach (var car in cars)
            {
                Console.WriteLine(car.Manufacturer);
            }
          
        }

        private static List<Car> ProcessFile(string path)
        {
           // Operator syntax
           return
                File.ReadAllLines(path)
                .Skip(1)
                .Where(line => line.Length > 1)
                .Select(Car.ParseFromCsv) //Named Function
                .ToList();


            // Query syntax
            //var query =
            //    from Line in File.ReadAllLines(path).Skip(1)
            //    where Line.Length > 1
            //    select Car.ParseFromCsv(Line);

            //return query.ToList();
        }

        
    }
}
