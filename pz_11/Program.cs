using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Это произвольный текст. Он состоит из нескольких предложений. Можем отсортировать их по возрастанию количества слов.";
            string[] sentences = text.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            Array.Sort(sentences, (s1, s2) => s1.Split(' ').Length.CompareTo(s2.Split(' ').Length));

            Console.WriteLine("Предложения отсортированы по возрастанию количества слов:");
            foreach (string sentence in sentences)
            {
                Console.WriteLine(sentence.Trim());
            }

            Console.ReadKey();
        }
    }
}
