using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _3_LINQ_Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var movies = new List<Movie>
            { 
                new Movie{Title="The Dark knight",Rating=8.9f,Year=2008},
                new Movie{Title="The King's Space ",Rating=9.0f,Year=2010},
                new Movie{Title="Casablance",Rating=5.9f,Year=1942},
                new Movie{Title="Star War V",Rating=6.9f,Year=1980}
            };
            //Q1-get Movies that published after 2000
            var query = movies.Where(m => m.Year >= 2000).ToList();
            foreach (var movie in query)
            {
                Console.WriteLine( movie.Title);
            }

            //Q2-Get first movie where rating >=9
            var query2 = movies.Where(m => m.Rating >= 0).Take(1);
            foreach (var item in query2)
            {
                Console.WriteLine(item.Title);
            }
            //Q3-Get All Movies order by year 
            var query3 = movies.OrderBy(m => m.Year).ToList();
            foreach (var item in query3)
            {
                Console.WriteLine(item.Title+" : "+item.Year);
            }
        }
    }
}
