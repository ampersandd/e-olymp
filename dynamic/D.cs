using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olymp
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine().Trim());
            var cache = new long[100];

            cache[0] = 2;
            cache[1] = 3;

            for (int i = 2; i < capacity; i++)
                cache[i] = cache[i - 1] + cache[i - 2];


            Console.WriteLine(cache[capacity - 1]);
        }
    }
}