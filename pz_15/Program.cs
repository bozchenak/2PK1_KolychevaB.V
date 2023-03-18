using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filename = "data.txt";
            double sum = 0;

            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(' ');
                    int index = int.Parse(parts[0]);
                    double amount = double.Parse(parts[1]);
                    sum += amount;
                }
            }

            Console.WriteLine("Общая сумма: " + sum.ToString("F2"));
            Console.ReadKey();
        }
    }
}
