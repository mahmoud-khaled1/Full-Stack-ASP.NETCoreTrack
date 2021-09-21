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
            Employee[] developers = new Employee[]
            {
                new Employee{Id=1,Name="mahmoud"},
                new Employee{Id=2,Name="Waledd"}
            };
            var sales = new List<Employee>()
            {
                new Employee { Id = 3, Name = "Alex" }
            };

        }
    }
}
