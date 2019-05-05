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
            var commands = Console.ReadLine().Trim().ToCharArray();

            int l = 0, x = 0, r = 0;

            for (int i = 0; i < commands.Count(); i++)
            {
                if (commands[i] == 'R') x++;
                if (commands[i] == 'L') x--;

                if (x > r) r = x;
                if (x < l) l = x;
            }
            Console.WriteLine(r - l + 1);
        }
    }
}
