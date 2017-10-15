
using System;
using System.Linq;

namespace ConsoleAppArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] monthsName = new string[] 
               { "January","February","March","April","May","June","July","August", "September", "October", "November",  "December" };
            // C# program that uses LINQ
            var sortAscending = from months in monthsName
                                orderby months
                                select months;
            var sortDescending = from months in monthsName
                                 orderby months descending
                                 select months;
            Console.WriteLine("------sort ascending----------");
            foreach (string i in sortAscending)
                Console.WriteLine(i);
        }
    }
}
