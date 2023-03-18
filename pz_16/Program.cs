using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace pz_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = 3; 
            string filePath = "example.txt"; 

            
            string[] lines = File.ReadAllLines(filePath);

            
            if (k > 0 && k <= lines.Length)
            {
                
                var list = new List<string>(lines);
                list.RemoveAt(k - 1);
                lines = list.ToArray();

               
                File.WriteAllLines(filePath, lines);
            }
            else
            {
                Console.WriteLine($"Строки с номером {k} нет в файле.");
            }
        }
    }
}
