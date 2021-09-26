using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Cars;

namespace Joining_Grouping_and_Aggregating
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = ProcessCars("fuel.csv");
            var manufactures = Processmanufactures("manufacturers.csv");

            //Join 

            // Get All information about Cars and their Manufacturers
            //method syntax
            var query1 = cars.Join(manufactures
                , c => c.Manufacturer, m => m.Name, 
               (c,m)=> new {Car=c,Manufacturer=m })
                .OrderByDescending(c=>c.Car.Combined).ToList();

            foreach (var item in query1)
            {
                Console.WriteLine(item.Car.Name + " : " + item.Car.Combined + " => " + item.Manufacturer.Headquarters);

                Console.WriteLine("-----------");
            }
            //Query syntax
            var query2 = (from car in cars
                         join manufacturer in manufactures
                         on car.Manufacturer equals manufacturer.Name
                         orderby car.Combined descending
                         select new { car.Name ,car.Combined, manufacturer.Headquarters}).ToList();

            foreach (var car in query2.Take(10))
            {
                Console.WriteLine(car.Name + " : " + car.Combined + " => " + car.Headquarters);

                Console.WriteLine("-----------");
            }

            //Join with more than one comPosite key 

            //method syntax
            var query3 = cars.Join(manufactures,
                c =>new { c.Manufacturer, c.Year},
                m=>new { Manufacturer = m.Name, m.Year},
               (c, m) => new { Car = c, Manufacturer = m })
               .OrderByDescending(c => c.Car.Combined).ToList();


            //Query syntax
            var query4 = (from car in cars
                          join manufacturer in manufactures
                          on new { car.Manufacturer, car.Year } 
                          equals new { Manufacturer=manufacturer.Name, manufacturer.Year }
                          orderby car.Combined descending
                          select new { car.Name, car.Combined, manufacturer.Headquarters }).ToList();


            //------------------------------------------------------------------
            //Grouping

            //method syntax

            var query5 = cars.GroupBy(c => c.Manufacturer)
                .OrderBy(m => m.Key).ToList();


            //Query synatax
            var query6 = from car in cars
                         group car by car.Manufacturer into m
                         orderby m.Key select m;

            foreach (var car in query6)
            {
                Console.WriteLine($"{car.Key} has {car.Count()} cars");
                foreach (var item in car/*.OrderByDescending(c=>c.Combined)*/)
                {
                    Console.WriteLine(item.Name);
                }
                Console.WriteLine("----------");
            }

            //GroupJoin 

            //method syntax

            var query7 = manufactures.GroupJoin(cars, m => m.Name, c => c.Manufacturer,
                (m, g) =>
                new
                {
                    Manufacturer = m,
                    Cars = g

                }).OrderByDescending(m => m.Manufacturer.Name);

            foreach (var car in query7)
            {
                Console.WriteLine($"{car.Manufacturer.Name}  :{car.Manufacturer.Headquarters}   ");
                foreach (var item in car.Cars)
                {
                    Console.WriteLine(item.Name);
                }
                Console.WriteLine("----------");
            }
            //---------------------------------------------------

            //Aggragating



            var query8 = from car in cars
                         group car by car.Manufacturer into CarGroup
                         select new
                         {
                             Name = CarGroup.Key,
                             Max = CarGroup.Max(c => c.Combined),
                             Min = CarGroup.Min(c => c.Combined),
                             Ave = CarGroup.Average(c => c.Combined)
                         };
            foreach (var car in query8)
            {
                Console.WriteLine(car.Name); 
                Console.WriteLine(car.Max+" "+car.Min+" "+car.Ave);
            }


        }

        private static IEnumerable<Manufacturer> Processmanufactures(string Path)
        {
            var result = File.ReadAllLines(Path)
                 .Skip(1)
                 .Where(c => c.Length > 1)
                 .Select(c=>
                 {
                     var columns = c.Split(',');
                     return new Manufacturer
                     {
                         Name = columns[0],
                         Headquarters = columns[1],
                         Year = int.Parse(columns[2])
                     };
                 });

            return result.ToList();
        }

        private static IEnumerable<Car> ProcessCars(string Path)
        {
            var result = File.ReadAllLines(Path)
                .Skip(1)
                .Where(c => c.Length > 1)
                .Select(Car.ParseFromCsv);
            return result;
        }
    }
}
