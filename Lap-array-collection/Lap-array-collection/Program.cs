using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap_array_collection
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[11];
            int sum;
            data[0] = 0;
            data[1] = 1;
            data[2] = 2;
            data[3] = 3;
            data[4] = 4;
            data[5] = 5;
            data[6] = 6;
            data[7] = 7;
            data[8] = 8;
            data[9] = 9;
            data[10] = 10;
            Console.WriteLine(data[7]);
            Console.WriteLine("sum of index 4 and index 9 = {0}", sum = data[4] + data[9]);
            if (data[2] == data[6])
            {
                Console.WriteLine("data of index 2 and data 6 is equal");
            }
            else
            {
                Console.WriteLine("data of index 2 and data 6 is not equal");
            }
            sum = data[0] + data[1] + data[2] + data[3] + data[4] + data[5] + data[6] + data[7] + data[8] + data[9] + data[10];
            Console.WriteLine("Total of array = {0}", sum);

            foreach(int i in data)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
