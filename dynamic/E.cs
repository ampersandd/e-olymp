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
            int houseCount = int.Parse(Console.ReadLine().Trim());
            var houseMoney = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(value => int.Parse(value.Trim())).ToArray();
            var result = new long[houseCount];

            result[0] = houseMoney[0];

            if (houseCount > 1)
                result[1] = Math.Max(houseMoney[0], houseMoney[1]);

            for (int i = 2; i < houseCount; i++)
                result[i] = Math.Max(houseMoney[i] + result[i - 2], result[i - 1]);


            Console.WriteLine(result[houseCount - 1]);
        }
    }
}
