using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "СЛОВО Слово сок сороконожка Соловей Салют";

            string[] words = s.ToUpper().Split(); 

            int count = 0;
            foreach (string word in words)
            {
                if (word.StartsWith("C") || word.StartsWith("С")) 
                {
                    count++; 
                }
            }

            Console.WriteLine($"Количество слов, начинающихся на букву С: {count}");
            Console.ReadKey();
        }
    }
}
