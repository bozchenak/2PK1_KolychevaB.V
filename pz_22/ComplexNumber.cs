using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_22
{
    internal class ComplexNumber
    {
        private double _realPart;
        private double _imaginaryPart;
        private static int _count;
        private static double _totalRealPart;
        private static double _totalImaginaryPart;

        public ComplexNumber(double realPart, double imaginaryPart)
        {
            _realPart = realPart;
            _imaginaryPart = imaginaryPart;
            _count++;
            _totalRealPart += realPart;
            _totalImaginaryPart += imaginaryPart;
        }

        public double RealPart
        {
            get { return _realPart; }
            set { _realPart = value; }
        }

        public double ImaginaryPart
        {
            get { return _imaginaryPart; }
            set { _imaginaryPart = value; }
        }

        public static int Count
        {
            get { return _count; }
        }

        public static double TotalRealPart
        {
            get { return _totalRealPart; }
        }

        public static double TotalImaginaryPart
        {
            get { return _totalImaginaryPart; }
        }

        public void PrintComplexNumber()
        {
            Console.WriteLine("{0} + {1}i", _realPart, _imaginaryPart);
        }

        public ComplexNumber GetMultiplicationByNumber(int number)
        {
            return new ComplexNumber(_realPart * number, _imaginaryPart * number);
        }

        public static void PrintStatistics()
        {
            Console.WriteLine("Общее количество созданных объектов: {0}", _count);
            Console.WriteLine("Суммарная действительная часть всех объектов : {0}", _totalRealPart);
            Console.WriteLine("Общая мнимая часть всех объектов: {0}", _totalImaginaryPart);
        }
    }
}
