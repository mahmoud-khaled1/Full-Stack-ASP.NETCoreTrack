using System;
using System.Collections.Generic;
using System.Text;

namespace intro_to_CSharp
{
     class Book
    {
        private List<double> li;
        private string name;
        public Book(string name)
        {
            this.name = name;
            li = new List<double>();
        }
        public void AddGrade(double grade)
        {
            li.Add(grade);
        }
        public void ShowStatistics()
        {
          
            var Sum = 0.0;
            var LowGrade = double.MaxValue;
            var hightGrade = double.MinValue;

            foreach (var item in li)
            {
                Sum += item;
                LowGrade = Math.Min(LowGrade, item);
                hightGrade = Math.Max(hightGrade, item);

            }
            Console.WriteLine($"Avg : {Sum/li.Count}");
            Console.WriteLine($"Lowest Value : {LowGrade}");
            Console.WriteLine($"Highest Value : {hightGrade}");
        }
    }

}
