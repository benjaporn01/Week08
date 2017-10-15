
using System;
using System.Linq;

namespace ConsoleAppArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] month = new string[] { "january",
              "febuary", "march", "april", "may", "june", "july","august", "september", "october",
              "november", "december"};
            Array.Sort(month);
            Console.WriteLine("------String sorting----------");
            foreach (string months in month)
                Console.WriteLine(month);
        }
    }
}
