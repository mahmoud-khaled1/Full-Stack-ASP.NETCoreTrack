using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace Collection_CSharp
{
    class CsvReader
    {
        private string  _csFilePath;

        public CsvReader(string csvFilePath)
        {
            this._csFilePath = csvFilePath;
        }
        public Country[] ReadFirstNCountries(int nCounteies)
        {
            Country[] countries = new Country[nCounteies];

            using(StreamReader sr = new StreamReader(this._csFilePath))
            {
                //read header line 
                sr.ReadLine();

                for(int i=0;i<nCounteies;i++)
                {
                    string csvLine = sr.ReadLine();
                    countries[i] = ReadCountryFromCsvLine(csvLine);
                }
            }

            return countries;
        }
        public List<Country> ReadAllCountries()
        {
            List<Country> countries = new List<Country>();

            using(StreamReader sr = new StreamReader(this._csFilePath))
            {
                //Read header of file 
                sr.ReadLine();
                string csvLine;
                while ((csvLine = sr.ReadLine())!=null)
                {
                    
                    countries.Add(ReadCountryFromCsvLine(csvLine));
                }
            }
            return countries;
        }
        public Dictionary<string,Country> ReadAllCountriesinDictionary()
        {
            var countries = new Dictionary<string, Country>();

            using (StreamReader sr = new StreamReader(this._csFilePath))
            {
                //Read header of file 
                sr.ReadLine();
                string csvLine;
                while ((csvLine = sr.ReadLine()) != null)
                {
                    Country c = ReadCountryFromCsvLine(csvLine);
                    countries.Add(c.Code,c);
                }
            }
            return countries;
        }
        public Country ReadCountryFromCsvLine(string CSVLine)
        {
            string[] parts = CSVLine.Split( ',' );

            string name="";
            string Code="";
            string Continent="";
            string Population="";

            if (parts.Length==4)
            {
                 name = parts[0];
                 Code = parts[1];
                 Continent = parts[2];
                 Population = parts[3];
            }
            else if(parts.Length==5)
            {
                 name = parts[0]+", "+parts[1];
                 name = name.Replace("\"", null).Trim();
                 Code = parts[2];
                 Continent = parts[3];
                 Population =parts[4];
            }
            else
            {
                throw new Exception("Can't Read this File");
            }


            return new Country(name, Code, Continent, int.Parse(Population));

        }
        public void RemoveCommaCountries(List<Country>countries)
        {
            for (int i = countries.Count-1; i > 0 ; i--) // we start from bact to avoid missing any country because of resize the list   
            {
                if (countries[i].Name.Contains(','))
                    countries.RemoveAt(i);
            }
        }
        public Dictionary<string, List<Country>> ReadAllCountriesbyRegioninDictionary()
        {
            var countries = new Dictionary<string,List<Country>>();

            using (StreamReader sr = new StreamReader(this._csFilePath))
            {
                //Read header of file 
                sr.ReadLine();
                string csvLine;
                while ((csvLine = sr.ReadLine()) != null)
                {
                    Country country = ReadCountryFromCsvLine(csvLine);
                    if(countries.ContainsKey(country.Region))
                    {
                        countries[country.Region].Add(country);
                    }
                    else
                    {
                        List<Country> countriesInRegion = new List<Country>() { country };
                        countries.Add(country.Region, countriesInRegion);

                    }
                }
            }
            return countries;
        }


    }
}
