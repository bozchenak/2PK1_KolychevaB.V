using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_21
{
    internal class ComplexNumber
    {
        private double a; 
        private const double i = 1.0; 
        private double b; 

        public ComplexNumber(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public void PrintComplexNumber()
        {
            Console.WriteLine($"{a}+{b}i");
        }

        public ComplexNumber GetMultiplicationByNumber(int number)
        {
            double newA = a * number;
            double newB = b * number;
            return new ComplexNumber(newA, newB);
        }
    }
}
