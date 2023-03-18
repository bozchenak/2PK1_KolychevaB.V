using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int result = SumOfEvenNumbersAtOddPositions(arr);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        public static int SumOfEvenNumbersAtOddPositions(int[] arr)
        {
            int sum = 0;
            for (int i = 1; i < arr.Length; i += 2)
            {
                if (arr[i] % 2 == 0)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }
    }
}
