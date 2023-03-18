using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 6;

            double result = 1.0; 

            for (int i = n; i >= 1; i -= 2)
            {
                result *= i;
            }

            if (n % 2 == 0)
            {
                result /= 2;
            }
            else
            {
                result /= 1;
            }

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
