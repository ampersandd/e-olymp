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
            var n = int.Parse(Console.ReadLine());
            var arr = new int[n + 2];
            arr[1] = 1;

            for (int i = 2; i <= n + 1; i++)
            {
                arr[i] = i;
                for (int j = 1; 2 * j < i; j++)
                {
                    if (arr[j] + arr[i - j] < arr[i])
                        arr[i] = arr[j] + arr[i - j];
                }
                for (int j = 2; j * j <= i; j++)
                {
                    if (i % j == 0 && arr[j] + arr[i / j] < arr[i])
                        arr[i] = arr[j] + arr[i / j];
                }
            }
            Console.WriteLine(arr[n]);
        }
    }
}
