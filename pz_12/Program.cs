using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                int factorial = Factorial(i);
                sum += factorial;
            }

            Console.WriteLine(sum);
            Console.ReadKey();
        }

        public static int Factorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }
    }
}
