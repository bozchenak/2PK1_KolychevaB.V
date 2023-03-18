using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] A = new double[8, 6]; 

            Random rnd = new Random();
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    A[i, j] = rnd.NextDouble() * 100 - 50; 
                }
            }

            double min = A[0, 0]; 
            double sum = 0; 

            // находим минимальный элемент матрицы и сумму положительных элементов
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (A[i, j] < min)
                    {
                        min = A[i, j]; 
                    }

                    if (A[i, j] > 0)
                    {
                        sum += A[i, j]; 
                    }
                }
            }

            double result = min * sum; 

            Console.WriteLine("Матрица:");
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(A[i, j] + " "); 
                }
                Console.WriteLine();
            }

            Console.WriteLine("Минимальный элемент матрицы: " + min);
            Console.WriteLine("Сумма положительных элементов матрицы: " + sum);
            Console.WriteLine("Произведение минимального элемента на сумму положительных элементов: " + result);
            Console.ReadKey();

        }
    }
}
