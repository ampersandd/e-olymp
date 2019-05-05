using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olymp
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var array = new int[n + 2];
            var line = Console.ReadLine().Trim().Split(' ').Select(x => int.Parse(x)).ToArray();
            line.CopyTo(array, 1);

            var k = int.Parse(Console.ReadLine());
            var j = 0;
            var max = 0;
            for (int i = 1; i <= n + 1; i++)
            {
                max = array[j];
                for (j = i - k; j < i; j++)
                {
                    if (j < 0) j = 0;
                    if (array[j] > max) max = array[j];
                }
                array[i] += max;
            }

            Console.WriteLine(array[n + 1]);
        }
    }
}
