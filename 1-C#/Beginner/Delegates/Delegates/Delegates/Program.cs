using System;
using System.Collections.Generic;
namespace Delegates
{
    class Program
    {
        //A delegate is an object that knows how to call a method.

        /* any instance of this delegates type can call any method that must 
           match theses specification 1-Returns void  2-take one parameters of type string */
        delegate void MyDeletates(string s);
        delegate string MyDeletates2(string s, int a);
        delegate void MyDeletates3();
        delegate int MyDeletates4(int x);
        public delegate bool Ispromoted(Employee e);
        // Multicast selegates
        delegate void SampleDelegate();

        static void Main(string[] args)
        {

            #region singlecast delegates
            //  void SayHello(string s) => Console.WriteLine($"Hello : {s}");
            //  int Square(int n) => n * n;
            //  int Cube(int n) => n * n * n;



            //  //How to define deletates instance
            //  MyDeletates d = SayHello; // d is instance of delegate MyDeletates and pointer to function SayHello 
            //  MyDeletates d = mew MyDeletates(SayHello) // Valid
            //  // How to invoke a method
            //  d.Invoke("mahmoud");

            //  Console.WriteLine("----------------------------");

            //  MyDeletates2 d2 = Test.MyInfo;
            //  Console.WriteLine(d2.Invoke("mahmoud", 22));

            //  Console.WriteLine("----------------------------");

            //  person p1 = new person("Aly", "Assiut", 25);
            //  MyDeletates3 d3 = p1.ShowInfo;
            //  d3.Invoke();

            //  Console.WriteLine("----------------------------");

            //  //System.Delegate;
            //  if (d3.Target == p1)
            //      Console.WriteLine("Delegate d3 hold reference of object p1");

            //  Console.WriteLine("----------------------------");

            //  int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //  MyDeletates4 d4 = Square;
            //  Transform(numbers, d4);
            ////Transform(numbers, Square); // Valid
            //  Console.WriteLine("Array After Transform :");

            //  foreach (var item in numbers)
            //  {
            //      Console.WriteLine(item);
            //  }

            // Example 

            //Employee e1 = new Employee() { Id = 101, Name = "mahmoud", Salary = 10000 };
            //Employee e2 = new Employee() { Id = 102, Name = "Aly", Salary = 2000 };
            //Employee e3 = new Employee() { Id = 103, Name = "Ahmed", Salary = 6000 };
            //Employee e4 = new Employee() { Id = 104, Name = "Tamer", Salary = 5000 };

            //List<Employee> emp = new List<Employee>();
            //emp.Add(e1);
            //emp.Add(e2);
            //emp.Add(e3);
            //emp.Add(e4);

            //Ispromoted pro = new Ispromoted(Promote);
            //Employee.promoted(emp, pro);

            //Employee.promoted(emp, emp => emp.Salary >= 5000); // Valid

            #endregion

            #region multiplecast delegates
            // multiplecast delegates is a delegate that has references to more than one function
            //when you invoke a multicast delegate all function the delegate pointing on them are invoked 

            SampleDelegate del1,del2,del3,del4,del5;
            //del1.Invoke();
            del1 = new SampleDelegate(SampleMethodOne);
            del2 = new SampleDelegate(SampleMethodTwo);
            del3 = new SampleDelegate(SampleMethodThree);
            del4 = new SampleDelegate(SampleMethodFour);

            del5 = del1 + del2 + del3+del4;
            del5 -= del3;

            del5.Invoke();

            // And we can do that 
            SampleDelegate del = new SampleDelegate(SampleMethodOne);
            del += SampleMethodTwo;
            del += SampleMethodTwo;


            #endregion



        }
        public static void SampleMethodOne()
        {
            Console.WriteLine("SampleMethodOne is invoked !");
        }
        public static void SampleMethodTwo()
        {
            Console.WriteLine("SampleMethodTwo is invoked !");
        }
        public static void SampleMethodThree()
        {
            Console.WriteLine("SampleMethodThree is invoked !");
        }
        public static void SampleMethodFour()
        {
            Console.WriteLine("SampleMethodFour is invoked !");
        }

        public static bool Promote(Employee e)
        {
            if (e.Salary >= 5000)
                return true;
            else
                return false;
        }
        public class Employee
        {
            public int Id { get; set; }
            public  string Name { get; set; }
            public int Salary { get; set; }

            public static void promoted(List<Employee>emps,Ispromoted IsPro)
            {
                foreach (var item in emps)
                {
                    if(IsPro.Invoke(item))
                    {
                        Console.WriteLine(item.Name+"  Promoted");
                    }
                }
            }
            
        }

        static void Transform(int[] numbers,MyDeletates4 dele)
        {
            for(int i=0;i<numbers.Length;i++)
            {
                numbers[i] = dele.Invoke(numbers[i]);
            }
        }
        class Test
        {
            public static string MyInfo(string name,int age)
            {
                return $"Hello {name} Your age is {age}";
            }
        }
        class person
        {
            public string name;
            public string address;
            public int age;

            public person(string n,string add,int a)
            {
                this.name = n;
                this.address = add;
                this.age = a;
            }

            public void ShowInfo()
            {
                Console.WriteLine($"Your name :{this.name} Your age :{this.age} Your address :{this.address}");
            }
        }
    }
}
