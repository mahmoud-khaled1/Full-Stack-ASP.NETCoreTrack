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
            //Q1-Get the car that has the best fuel efficiency and if we have more 
            // than car have same fuel then sort by name ;

            // Operator syntax
            var query1 = cars.OrderByDescending(c => c.Combined)
                .ThenByDescending(c=>c.Name).FirstOrDefault();

            Console.WriteLine(query1.Name+" : "+query1.Combined);

            // Query syntax
            var query2 = (from car in cars
                         orderby car.Combined descending, car.Name descending
                         select car).FirstOrDefault();
            Console.WriteLine(query2.Name+" : "+query2.Combined);

            //Q2-Get all cars that manufactuer is  BMW

            // Operator syntax
            var query3 = cars.Where(c => c.Manufacturer == "BMW").ToList();
            foreach (var car in query3)
            {
                Console.WriteLine(car.Name+" : "+car.Manufacturer);
            }
            // Query syntax
            var query4 = (from car in cars
                         where car.Manufacturer == "BMW"
                         select car).ToList();
            foreach (var car in query4)
            {
                Console.WriteLine(car.Name + " : " + car.Manufacturer);
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
