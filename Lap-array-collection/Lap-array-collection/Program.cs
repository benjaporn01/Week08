using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        Console.WriteLine("------sort descending----------");
        foreach (string i in sortDescending)
            Console.WriteLine(i);
        Console.ReadKey();
          
    }
}