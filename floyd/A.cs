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
            int size = int.Parse(Console.ReadLine().Trim());

            var matrix = new int[size][];
            for (int i = 0; i < size; i++)
                matrix[i] = ReadValuesFromRow();

            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    for (int k = 0; k < size; k++)
                        matrix[j][k] = Math.Min(matrix[j][k], matrix[j][i] + matrix[i][k]);

            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }

        static int[] ReadValuesFromRow()
        {
            return Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(value => int.Parse(value.Trim())).ToArray();
        }
    }
}