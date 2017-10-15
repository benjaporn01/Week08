
using System;

namespace ConsoleAppArray
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] data = new float[9];
            Console.Write("Enter GPS. term 1:");
            data[0] = float.Parse(Console.ReadLine());
            Console.Write("Enter GPS. term 2:");
            data[1] = float.Parse(Console.ReadLine());
            Console.Write("Enter GPS. term 3:");
            data[2] = float.Parse(Console.ReadLine());
            Console.Write("Enter GPS. term 4:");
            data[3] = float.Parse(Console.ReadLine());
            Console.Write("Enter GPS. term 5:");
            data[4] = float.Parse(Console.ReadLine());
            Console.Write("Enter GPS. term 6:");
            data[5] = float.Parse(Console.ReadLine());
            Console.Write("Enter GPS. term 7:");
            data[6] = float.Parse(Console.ReadLine());
            Console.Write("Enter GPS. term 8:");
            data[7] = float.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("GPS. of term 1 ={0}",data[0]);
            Console.WriteLine("GPS. of term 1 ={0}", data[1]);
            Console.WriteLine("GPS. of term 1 ={0}", data[2]);
            Console.WriteLine("GPS. of term 1 ={0}", data[3]);
            Console.WriteLine("GPS. of term 1 ={0}", data[4]);
            Console.WriteLine("GPS. of term 1 ={0}", data[5]);
            Console.WriteLine("GPS. of term 1 ={0}", data[6]);
            Console.WriteLine("GPS. of term 1 ={0}", data[7]);
            Console.WriteLine("GPS. of term 1 ={0}", data[8]);
            Console.WriteLine("-----------------------------------------");           
            Console.WriteLine("GPA. = {0}",(data[0]+data[1]+ data[2]+ data[3] + data[4] + data[5]+data[6]+data[7]+data[8])/8);
            Console.ReadLine();
        }
    }
}
