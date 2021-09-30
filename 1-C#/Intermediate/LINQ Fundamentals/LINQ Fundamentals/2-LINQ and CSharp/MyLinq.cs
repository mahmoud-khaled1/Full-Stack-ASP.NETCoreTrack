using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_and_CSharp
{
    public static class MyLinq<T>
    {
        public static int  MyCount(IEnumerable<T> sequence)
        {
            int count = 0;
            foreach (var item in sequence)
            {
                count++;
            }
            return count;
        }
    }
}
