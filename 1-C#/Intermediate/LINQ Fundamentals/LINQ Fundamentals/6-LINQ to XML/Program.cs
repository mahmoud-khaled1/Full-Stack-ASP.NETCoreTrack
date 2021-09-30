using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;

namespace LINQ_to_XML
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateXml();
            QueryXml();
        }

        private static void QueryXml()
        {
            var document = XDocument.Load("fuel.xml");
        
            var query =
                from element in document.Element( "Cars")?.Elements( "Car")
                                                       ?? Enumerable.Empty<XElement>()
                where element.Attribute("Manufacturer")?.Value == "BMW"
                select element.Attribute("Name").Value;

            foreach (var name in query)
            {
                Console.WriteLine(name);
            }

        }

        private static void CreateXml()
        {
            var records = ProcessCars("fuel.csv");
            var document = new XDocument();
            var cars = new XElement("Cars");

            var elements = from record in records
                           select new XElement("Car",
                           new XAttribute("Name", record.Name),
                           new XAttribute("Combined", record.Combined),
                           new XAttribute("Manufacturer", record.Manufacturer)
                     );
            cars.Add(elements);
            document.Add(cars);
            document.Save("fuel.xml");
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
    public static class CarExtensions
    {
        public static IEnumerable<Car> ToCar(this IEnumerable<string> source)
        {
            foreach (var line in source)
            {
                var columns = line.Split(',');

                yield return new Car
                {
                    Year = int.Parse(columns[0]),
                    Manufacturer = columns[1],
                    Name = columns[2],
                    Displacement = double.Parse(columns[3]),
                    Cylinders = int.Parse(columns[4]),
                    City = int.Parse(columns[5]),
                    Highway = int.Parse(columns[6]),
                    Combined = int.Parse(columns[7])
                };
            }
        }
    }

}
