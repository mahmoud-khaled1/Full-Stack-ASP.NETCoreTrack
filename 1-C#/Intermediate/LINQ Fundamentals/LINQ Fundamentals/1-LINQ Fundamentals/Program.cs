using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace LINQ_Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Linq (language integrated query) used to query and manipulate 
              data from different data source such as Linq to Collection 
              Linq to Sql Linq to XML ,Json  and any data source 
              that implement IEnumerable Interface */
            //-----------------
            // 1- introduction 
            string path = @"C:\windows";
            ShowLargeFileWithoutLinq(path);
            Console.WriteLine("---------------------------------------");
            ShowLargeFileWithLinq(path);


        }
        private static void ShowLargeFileWithLinq(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            FileInfo[] files = directory.GetFiles();

            //var query = from file in files
            //            orderby file.Length descending
            //            select file;
            var query = files.OrderByDescending(f => f.Length).ToList();
            foreach (var file in query/*.Take(5)*/)
            {
                Console.WriteLine($"{file.Name,-25} : {file.Length,10:N0}");
            }
        }

        private static void ShowLargeFileWithoutLinq(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            FileInfo[]files= directory.GetFiles();
            Array.Sort(files,new FileInfoComparer());
            foreach (var file in files)
            {
                Console.WriteLine($"{file.Name,-25} : {file.Length,10:N0}");
            }
        }
    }
    public class FileInfoComparer : IComparer<FileInfo>
    {
        public int Compare(FileInfo x, FileInfo y)
        {
            return y.Length.CompareTo(x.Length);
        }  
    }
}
