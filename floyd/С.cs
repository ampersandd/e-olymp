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
            var result = new int[size][];

            for (int i = 0; i < size; i++)
            {
                matrix[i] = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select((value, j) =>
                    {
                        var parsedValue = int.Parse(value.Trim());
                        if (i != j && parsedValue == 0)
                            parsedValue = int.MaxValue;

                        return parsedValue;
                    }).ToArray();

                result[i] = new int[size];
            }

            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    for (int k = 0; k < size; k++)
                    {
                        if (matrix[j][i] == int.MaxValue || matrix[i][k] == int.MaxValue)
                            continue;


                        matrix[j][k] = Math.Min(matrix[j][k], matrix[j][i] + matrix[i][k]);
                    }

            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                {
                    if (matrix[i][j] == int.MaxValue)
                        result[i][j] = 0;
                    else
                    {
                        result[i][j] = 1;
                        for (int k = 0; k < size; k++)
                        {
                            if (matrix[k][k] < 0 && matrix[i][k] != int.MaxValue && matrix[k][j] != int.MaxValue)
                                result[i][k] = result[i][j] = result[k][j] = 2;
                        }
                    }

                }

            foreach (var row in result)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}