using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arithmetic = Arithmetic(4);
            Console.WriteLine("4:" + arithmetic);


            double geometric = Geometric(2);
            Console.WriteLine("2:" + geometric);
            Console.ReadLine();
        }

        public static int Arithmetic(int n)
        {
            if (n == 1)
            {
                return -95;
            }
            else
            {
                return Arithmetic(n - 1) + 5;
            }
        }

        public static double Geometric(int n)
        {
            if (n == 1)
            {
                return 12;
            }
            else
            {
                return 0.01 * Geometric(n - 1);
            }
        }
    }
}
