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
            var friendsCount = int.Parse(Console.ReadLine());
            var array = Console.ReadLine().Trim().Split(' ').Select(e => int.Parse(e)).ToArray();

            int maxElement = array.Max(), minElement = array.Min();

            var answer = Math.Ceiling((maxElement + 1) / (double)friendsCount);

            if (answer > minElement)
                Console.WriteLine(-1);
            else
                Console.WriteLine(answer);
        }
    }
}
