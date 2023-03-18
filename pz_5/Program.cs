using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            for (int i = -100; i <= 50; i += 5)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Задание 2");
            char latin = 'M';
            char cyrillic = 'М';

            for (int h = 0; h < 6; h++)
            {
                Console.Write(latin + " " + cyrillic + " ");
                latin++;
                cyrillic++;
                Console.WriteLine();
            }

            Console.WriteLine("Задание 3");

            for (int u = 0; u < 4; u++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Задание 4");
            for (int k = 0; k <= 100; k++)
            {
                if (k % 5 == 0)
                {
                    Console.Write(k + " ");
                }
            }
            Console.ReadKey();
        }
    }
}
