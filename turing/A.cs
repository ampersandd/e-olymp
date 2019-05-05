using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eOlymp.Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());

            var deviders = new List<int>();
            int max = (int)Math.Sqrt(a);

            for (int f = 1; f <= max; ++f)
            {
                if (a % f == 0)
                {
                    deviders.Add(f);

                    var aDevidedByFactor = a / f;
                    if (f != aDevidedByFactor)
                        deviders.Add(a / f);
                }
            }
            deviders.Sort();
            Console.WriteLine(string.Join(" ", deviders));
        }
    }
}
