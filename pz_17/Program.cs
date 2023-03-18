using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            unsafe { 
            double[] arr = { 1.2, 3.4, 5.6, 7.8, 9.0 };
            fixed (double* ptr = &arr[0])
                { 
                    double sum = 0;
                    int n = arr.Length;
                    for (int i = 0; i < n; i++, ptr++)
                    {
                        sum += *ptr;
                    }
                    double average = sum / n;
                    Console.WriteLine("Среднее значение элементов массива: " + average);
                }
            }
        }
    }
}
