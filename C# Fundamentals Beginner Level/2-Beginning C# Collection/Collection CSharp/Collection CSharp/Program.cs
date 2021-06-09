using System;
using System.Collections.Generic;
using System.Linq;
namespace Collection_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Array
            // Array is fixed numbers of same item 
            string[] daysofweek = {
                "Saterday", 
                "Sunday", 
                "Monday", 
                "Tuesday", 
                "Wendesday", 
                "Thuresday", 
                "Friday" };

            //foreach (var day in daysofweek)
            //{
            //    Console.WriteLine(day);
            //}

            //Example :import top 10 countries from csv file

            //string filepath = @"D:\Git_Projects\ASP.Net-MentorShip-\Beginning C# Collection\Pop by Largest Final.csv";
            //CsvReader reader = new CsvReader(filepath);
            //Country[] countries = reader.ReadFirstNCountries(10);

            //foreach (Country country in countries)
            //{
            //    Console.WriteLine($"{country.Name} : {country.Population}");
            //}

            #endregion

            #region List
            ////List is dynamic array that can be resize
            //List<string> dayOfWeek = new List<string>();
            //dayOfWeek.Add("Saterday");
            //dayOfWeek.Add("Sunday");
            //dayOfWeek.Add("Monday");
            //dayOfWeek.Add("Tuesday");
            //dayOfWeek.Add("Wendesday");
            //dayOfWeek.Add("Thuresday");
            //dayOfWeek.Add("Friday");

            ////Example :import all countries from csv file


            //string filepath = @"D:\Git_Projects\ASP.Net-MentorShip-\Beginning C# Collection\Pop by Largest Final.csv";
            //CsvReader reader = new CsvReader(filepath);
            //List<Country> countries = reader.ReadAllCountries();

            //int indx = countries.FindIndex(x => x.Population == 263991379);

            //Console.WriteLine($"index : {indx}");
            //foreach (Country country in countries)
            //{
            //    Console.WriteLine($"{country.Name} : {country.Population}");
            //}



            #endregion

            #region Dictionary
            //Country c1 = new Country("norway", "NOR", "Europe", 100000);
            //Country c2 = new Country("Finland", "FIN", "Europe", 250000);


            //Dictionary<string, Country> countries = new Dictionary<string, Country>
            //{
            //    { "NOR", c1 },
            //    { "FIN", c2 }

            //};
            //Console.WriteLine(countries["NOR"].Population);
            //Country newCo = countries["FIN"];

            //Console.WriteLine("----------------------");
            //foreach (var country in countries.Values)
            //{
            //    Console.WriteLine(country.Population);
            //}

            //check if key is exist in the dictionary !
            //bool exists = countries.TryGetValue("mah", out Country cou);

            //Console.WriteLine(exists);
            //Console.WriteLine("-----------------------------------");
            //string filepath = @"D:\Git_Projects\ASP.Net-MentorShip-\Beginning C# Collection\Pop by Largest Final.csv";
            //CsvReader reader = new CsvReader(filepath);
            //Dictionary<string, Country> countries = reader.ReadAllCountriesinDictionary();

            //Console.WriteLine("Which Country code fo you want to search for ?");
            //string inputCode = Console.ReadLine();

            //bool IsExists = countries.TryGetValue(inputCode, out Country c);

            //if(IsExists)
            //{
            //    Console.WriteLine($"Country name :{countries[inputCode].Name}\nCountry Population :{countries[inputCode].Population}");
            //}
            //else
            //{
            //    Console.WriteLine("Country not found");
            //}

            #endregion

            #region Manipulating List Data


            //string filepath = @"D:\Git_Projects\ASP.Net-MentorShip-\Beginning C# Collection\Pop by Largest Final.csv";
            //CsvReader reader = new CsvReader(filepath);
            //List<Country> countries = reader.ReadAllCountries();

            //reader.RemoveCommaCountries(countries);
            ////Or we can do this instead of this function 
            //countries.RemoveAll(co => co.Name.Contains(','));

            //for (int i = 0; i < countries.Count; i++)
            //{
            //    Console.WriteLine($"County name :{countries[i].Name}");
            //}
            #endregion

            #region Selection Items using Linq
            //LINQ is read-only 

            //string filepath = @"D:\Git_Projects\ASP.Net-MentorShip-\Beginning C# Collection\Pop by Largest Final.csv";
            //CsvReader reader = new CsvReader(filepath);
            //List<Country> countries = reader.ReadAllCountries();
            //lambda expression

            //foreach (Country country in countries.OrderBy(co=>co.Name).Take(10))
            //{
            //    Console.WriteLine($"{country.Name} : {country.Population}");
            //}

            //Removing Countries without Commas 
            //foreach (Country country in countries.Where(x=>!x.Name.Contains(',')))
            //{
            //    Console.WriteLine($"{country.Name} : {country.Population}");
            //}
            // we can use Linq Query syntax to solve this 
            //var FilterCountries = from country in countries
            //                      where !country.Name.Contains(',')
            //                      select country;

            //foreach (Country country in FilterCountries)
            //{
            //    Console.WriteLine($"{country.Name} : {country.Population}");
            //}
            #endregion

            #region Collections of Collections
            // Display Countries in Region like --> user type :South America app display :Brazil,Colombia,...
            //We will use Dictionary <string,Lsit<country>>


            //string filepath = @"D:\Git_Projects\ASP.Net-MentorShip-\Beginning C# Collection\Pop by Largest Final.csv";
            //CsvReader reader = new CsvReader(filepath);
            //Dictionary<string,List<Country>> countries = reader.ReadAllCountriesbyRegioninDictionary();


            //foreach (var item in countries.Keys)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("-----------------------");

            //Console.WriteLine("Enter Region Name :");
            //string inputRegion = Console.ReadLine();

            //if(countries.ContainsKey(inputRegion))
            //{
            //    foreach ( Country country in countries[inputRegion])
            //    {
            //        Console.WriteLine($"Country name :{country.Name}\nCountry Population :{country.Population}");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invaid Region !");
            //}


            #endregion
        }
    }
}
