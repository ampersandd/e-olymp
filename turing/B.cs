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
            var inputs = Console.ReadLine().Split(' ').Select(e => int.Parse(e)).ToArray();
            int a = inputs[0], p = inputs[1], b = inputs[2], weeksCount = 0;

            double dailyPayment, lastPayment = 0, debt = a, solvency = 0;

            while (debt > 0)
            {
                for (int i = 0; i < 7; i++)
                {
                    dailyPayment = (p * debt) / 100;
                    solvency += dailyPayment;
                    debt += dailyPayment;
                }

                if (b <= solvency)
                {
                    Console.WriteLine(-1);
                    return;
                }

                solvency = 0;
                weeksCount++;
                lastPayment = debt;
                debt -= b;
            }
            Console.WriteLine("{0} {1:0.00}", weeksCount, lastPayment);
        }
    }
}
