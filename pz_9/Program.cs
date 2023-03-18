using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            char a = (char)random.Next(3, 50);
            char[][] array = new char[10][];
            char k = 'f';
            Console.WriteLine("1 задание");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                array[i] = new char[k = (char)random.Next(3, 10)];

                for (int j = 0; j < k; j++)
                {
                    array[i][j] = (char)random.Next(3, 10);
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            Console.Write("3 задание ");
            char[] arrayEnd = new char[10];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                arrayEnd[i] = array[i][array[i].Length - 1];
                Console.Write(arrayEnd[i] + " ");
            }
            Console.WriteLine();


            Console.Write("4 задание ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write(arrayEnd[i] = array[i].Max());
            }
            Console.WriteLine();


            Console.WriteLine("5 задание ");
            char firstValue;
            char maxValue;
            for (int i = 0, j = 0; i < array.GetLength(0); i++)
            {
                maxValue = array[i].Max();
                int index = Array.IndexOf(array[i], maxValue);
                firstValue = array[i][j];
                array[i][j] = array[i].Max();
                array[i][index] = firstValue;
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            Console.WriteLine("6 задание");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = array[i].Length - 1; j >= 0; j--)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
