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
            var inputs = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(value => int.Parse(value.Trim())).ToArray();
            int width = Math.Min(inputs[0], inputs[1]);
            int length = Math.Max(inputs[0], inputs[1]);

            var results = new long[length + 1];

            results[1] = 4;

            if (length > 1)
                results[2] = 6;

            for (int i = 3; i <= length; i++)
            {
                results[i] = 4 + 2 * (i - 1);

                for (int j = 2; j < i; j++)
                {
                    var alternativePath = results[j] + 4 + 2 * ((i - j - 1) / j);
                    if (alternativePath < results[i])
                        results[i] = alternativePath;
                }
            }


            if (width == 1)
                Console.WriteLine(results[length]);
            else
                Console.WriteLine(results[length] + results[width] - 2);
        }
    }
}