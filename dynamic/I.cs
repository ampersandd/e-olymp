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
            var n = int.Parse(Console.ReadLine().Trim());
            if (n < 2)
            {
                Console.WriteLine(1);
                return;
            }

            var list = new List<int[]> { new int[] { 1 }, new int[] { 1 } };

            for (int i = 2; i < n; i++)
                list.Add(AddArrays(list[i - 1], list[i - 2]));

            Console.WriteLine(ArrayToString(list.Last()));
        }

        static int[] AddArrays(int[] arr1, int[] arr2)
        {
            if (arr1.Length > arr2.Length)
                arr2 = ConvertArray(arr2, arr1.Length);
            else if (arr1.Length < arr2.Length)
                arr1 = ConvertArray(arr1, arr2.Length);

            var sum = new List<int>();
            var transfer = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                var sumPlusTransfer = arr1[i] + arr2[i] + transfer;
                if (sumPlusTransfer < 10)
                {
                    sum.Add(sumPlusTransfer);
                    transfer = 0;
                }
                else
                {
                    sum.Add(sumPlusTransfer % 10);
                    transfer = 1;
                }
            }
            if (transfer != 0)
                sum.Add(transfer);

            return sum.ToArray();
        }

        static int[] ConvertArray(int[] arr, int length)
        {
            var newArray = new int[length];
            arr.CopyTo(newArray, 0);
            return newArray;
        }

        static string ArrayToString(int[] arr) => string.Join("", arr.Reverse());
    }
}
