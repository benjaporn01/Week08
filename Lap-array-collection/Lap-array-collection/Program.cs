
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
            Array.Sort(monthsName);
            var sortAscending = from months in monthsName
                                orderby months
                                select months;
          

            Console.WriteLine("------String sorting----------");
            foreach (string name in monthsName)
                Console.WriteLine(monthsName);
            Console.ReadLine();

        }
    }
}
