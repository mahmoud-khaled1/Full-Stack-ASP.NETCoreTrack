using System;
using System.Collections.Generic;
namespace intro_to_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assignment 1

            List<double> li = new List<double>();
            int num;
            Console.WriteLine("Enter Number of grades :");
            num = Convert.ToInt32(Console.ReadLine());

            double result = 0.0;
            for (int i = 0; i < num; i++)
            {
                double number;
                number = Convert.ToDouble(Console.ReadLine());
                li.Add(num);
                result += number;
            }
            Console.WriteLine($"Sum of Grade :{result}");
            Console.WriteLine($"Average of Grades :{result/li.Count}");



        }
    }
}
