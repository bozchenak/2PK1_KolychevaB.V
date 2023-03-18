using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ComplexNumber c1 = new ComplexNumber(1, 2);
            ComplexNumber c2 = new ComplexNumber(3, 4);
            ComplexNumber c3 = new ComplexNumber(5, 6);

            ComplexNumber.PrintStatistics();
            Console.ReadKey();
        }
    }
}
