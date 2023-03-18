using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 }; // пример заданного массива
            int k = 0; // инициализируем счетчик четных чисел

            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] % 2 == 0) // проверяем, является ли текущий элемент четным
                {
                    Console.Write(array[i] + " "); // выводим текущий элемент на экран
                    k++; // увеличиваем счетчик четных чисел
                }
            }

            Console.WriteLine("\nКоличество четных чисел: " + k); // выводим количество четных чисел на экран
            Console.ReadKey();

        }
    }
}
