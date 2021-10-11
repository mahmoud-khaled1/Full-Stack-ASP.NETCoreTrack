using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expressions
{
    public static class StringHelper
    {
        public static bool IsCapitalized(this string str)
        {
            if (string.IsNullOrEmpty(str)) return false;

            return char.IsUpper(str[0]);
        }
    }

   
class Program
    {

        public static (string name , int Age, int[] arrofNumber) PrintAllInfo()
        {
            int[] arr = new int[5] { 1, 8, 7, 9, 5 };

            return (name:"mahmoud",Age: 23,arrofNumber: arr);
        }
        delegate int Transformer(int i);
        static void Main(string[] args)
        {
            #region Lambda Expressions
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Lambda Expressions");
            Console.ResetColor();
            Transformer sqr = x => x * x;
            Console.WriteLine(sqr.Invoke(5));
            Console.WriteLine("------------------");
            // Function with paramerter type and return type=parameters=>func expression                                    
            Func<string, string, int> totalLength = (s1, s2) => s1.Length + s2.Length;
            Console.WriteLine(totalLength("mahmoud","khaled"));
            Console.WriteLine("------------------");
            int speed = 0;
            Func<int> IncreaseSpeed = () => speed++;
            IncreaseSpeed();
            Console.WriteLine($"Speed:{speed}");
            Console.WriteLine("------------------");
            #endregion


            #region try Statements and Exceptions
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("try Statements and Exceptions");
            Console.ResetColor();

            try
            {
                Console.WriteLine(10/0.0);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
               //throw new DivideByZeroException("Divide By Zero !!!!");
            }
            finally
            {
                Console.WriteLine("Oh Shit here we go again !");
            }
            Console.WriteLine("------------------");

            #endregion

            #region Enumeration and Iterators
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Enumeration and Iterators");
            Console.ResetColor();
            //An enumerator is a read-only, forward-only cursor over a sequence of values

            foreach (var c in "mahmoud")
            {
                Console.WriteLine(c);
            }
            Console.WriteLine("-------------------");
            //Iterator Semantics
            IEnumerable<string>foo()
            {
                yield return "one";
                yield return "Two";
                yield return "Three";
            }
            foreach (var item in foo())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------");
            #endregion

            #region Nullable Value Types
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Nullable Value Types");
            Console.ResetColor();
            string str = null; //valid 
            //int i = null; //invalid
            int? i = null;  // valid
            if(i==null)
                Console.WriteLine("I is null");
            int? xx = 5;
            int? yy = 10;

            bool result = (xx.HasValue && yy.HasValue) ? (xx.Value < yy.Value) : false;
            Console.WriteLine(result);
            #endregion

            #region Extension Methods
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Extension Methods");
            Console.ResetColor();

            Console.WriteLine("Mahmoud".IsCapitalized());



            #endregion

            #region Anonymous Types
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Anonymous Types");
            Console.ResetColor();

            var dude = new { name = "mahmoud", age = 23 };

            Console.WriteLine(dude.name);
            Console.WriteLine(dude.GetType());

            //You can create arrays of anonymous types as follows:
            var arrDude = new[]
            {
                new {name="mahmoud",age=23},
                new {name="Waleed",age=26}
            };
            foreach (var item in arrDude)
            {
                Console.WriteLine(item.name);
            }
            #endregion

            #region Tuples
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Tuples");
            Console.ResetColor();

            //tuples provide a simple way to store a set of values. The
            //main purpose of tuples is to safely return multiple values from a method
            //without resorting to out parameters
            var bob = ("mahmoud", 23, "Assiut");
            Console.WriteLine(bob.Item1);
            Console.WriteLine(bob.Item2);

            //print the Tuple 
            Console.WriteLine(bob);
            //loop over collection that stored in Tuple !
            foreach (var item in bob.Item1)
            {
                Console.WriteLine(item);
            }
            var ans = PrintAllInfo();
            Console.WriteLine(ans);
            foreach (var item in ans.arrofNumber)
            {
                Console.WriteLine(item);
            }

            var time = DateTime.Now;
            var TupleOfTime = (time.Day, time.Month, time.Year);
            Console.WriteLine(TupleOfTime.Day);

            Tuple<string , int > T =Tuple.Create("Aly",28);
            Console.WriteLine(T.Item1);

            #endregion

            #region Records
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Records");
            Console.ResetColor();
            //A record is a special kind of class that’s designed
            //to work well with immutable (readonly) data.
                


            #endregion
            Console.ReadLine();
        }
    }
}
