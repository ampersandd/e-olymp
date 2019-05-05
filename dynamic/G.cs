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
            var matrix = new int[n][];

            for (int i = 0; i < n; i++)
            {
                matrix[i] = Console.ReadLine().Trim().ToCharArray()
                    .Select(c => int.Parse(c.ToString())).ToArray();
            }

            for (int i = 1; i < n; i++)
                matrix[i][0] += matrix[i - 1][0];
            for (int j = 1; j < n; j++)
                matrix[0][j] += matrix[0][j - 1];

            for (int i = 1; i < n; i++)
                for (int j = 1; j < n; j++)
                    matrix[i][j] += Math.Min(matrix[i - 1][j], matrix[i][j - 1]);

            int x = n - 1, y = n - 1;
            while (x != 0 || y != 0)
            {
                matrix[x][y] = -1;
                if (x > 0 && y > 0)
                {
                    if (matrix[x - 1][y] < matrix[x][y - 1]) x--;
                    else y--;
                }
                else if (x == 0) y--;
                else if (y == 0) x--;
            }
            matrix[0][0] = -1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i][j] == -1)
                        Console.Write("#");
                    else
                        Console.Write(".");
                }
                Console.WriteLine();
            }
        }
    }
}
