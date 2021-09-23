using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LINQ_and_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Employee> developers = new Employee[]
            {
                new Employee{Id=1,Name="sahmoud"},
                new Employee{Id=2,Name="Waledd"}
            };
            IEnumerable<Employee> sales = new List<Employee>()
            {
                new Employee { Id = 3, Name = "Alex" }
            };
            //Named Method 
            foreach (var developer in developers.Where(NameStartWithS))
            {
                Console.WriteLine(developer.Name);
            }
            //Delegate Method 
            foreach (var developer in developers.Where(
                delegate(Employee emp)
                {
                    return emp.Name.StartsWith('s');
                }))
            {
                Console.WriteLine(developer.Name);
            }
            //Lamada Expression 
            foreach (var developer in developers.Where(dev=>dev.Name.StartsWith('s')))
            {
                Console.WriteLine(developer.Name);
            }
            //----------------------------
            /*
             Func is a delegate that points to a method that accepts
             one or more arguments and returns a value. 
             */

             // summation of 2 value 
             Func<int, int, int> add = Sum;
             Console.WriteLine(add.Invoke(1,8));

            // GetRandomNumber between 1 and 100
            Func<int> getRandomNumber = () => new Random().Next(1, 100);
            Console.WriteLine(getRandomNumber.Invoke());

            // Return square of integer with delegate
            Func<int, int> Square = x => x * x;
            Console.WriteLine(Square.Invoke(2));

            //replace every * with # with delegate
            //Note : Func take 17 input param as maximum and last parm is the output.
            Func<string, string> Replace = str => str.Replace('*', '#');
            Console.WriteLine(Replace.Invoke("mahmoud*khaled"));

            // Add three value with Func delegate
            Func<int, int, int, int> Add = (x, y, z) =>
            {
                int temp;
                temp=x+y+z;
                return temp;
            };
            Console.WriteLine(Add.Invoke(5,10,2));

            /*
             Action is a delegate that points to a method which in turn accepts
             one or more arguments but returns no value. In other words, 
             you should use Action when your delegate points to a method 
             that returns void. 
             */
            Action<string> Print = PrintStr;
            Print.Invoke("mahmoud");

            Action<string> Print2 = str=>Console.WriteLine("Hello :"+str);
            Print2.Invoke("Aly");

            //Advantages of Action and Func Delegates:
            //1-Easy and quick to define delegates.
            //2-Makes code short.
            //3-Compatible type throughout the application.

            //----------------------------
            //Query syntax 
            string[] cities = { "Boston", "Los Angeles", "London", "Cairo" };

            var filterCities = from city in cities
                               where city.StartsWith('L') && city.Length < 15
                               orderby city
                               select city;
            //Note :Query syntax is start with from and end with select or group
            foreach (var city in filterCities)
            {
                Console.WriteLine(city);
            }
            // Operator syntax 
            var filterCities2 = cities.Where(c => c.StartsWith('L') && c.Length < 15)
                                    .OrderBy(c => c);
            foreach (var city in filterCities2)
            {
                Console.WriteLine(city);
            }

        }

        private static void PrintStr(string obj)
        {
            Console.WriteLine("Hello :"+obj);
        }

        private static int Sum(int x, int y)
        {
            return x + y;
        }

        private static bool NameStartWithS(Employee arg)
        {
            return arg.Name.StartsWith('s');
        }
    }
}
