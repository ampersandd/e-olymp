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
            int n;
            var list = new List<int> { 0 };

            using (var fs = File.OpenRead("input.txt"))
            using (var sr = new StreamReader(fs))
            {
                n = int.Parse(sr.ReadLine());
                list.AddRange(sr.ReadLine().Trim().Split(' ').Select(x => int.Parse(x)));
            }
            list[1] = 0;

            for (int i = 2; i <= n; ++i)
            {
                if (i - 3 >= 0)
                    list[i] += Math.Max(list[i - 2], list[i - 3]);
            }

            Console.WriteLine(list[n]);
        }
    }
}
