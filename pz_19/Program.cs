using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace pz_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            string text = "1 RU161109-472905 PACK19697671 1 Ольга Каверзина +7 (918) 335-43-52 Наличные Плюс 0\r\n09:00 - 13:00 Краснодар, красина, Дом 3/3, Кв. 76" + "\n2 RU161110-466130 PACK19651968 1 Софья Назаретян +7 (918) 398-07-81 Наличные Плюс 0\r\n09:00 - 13:00 Краснодар, Базовская, Дом д.61\n" +
                "\n3 RU161111-260536 PACK19698066 3 Виктор Кипуров +7 (918) 441-97-56 Наличные Плюс 0\r\n09:00 - 13:00 Краснодар, Речная,Чехова , Дом 4, Кв. 52\n" + "\n4 RU161111-522664 PACK19697905 2 Ирина Концевик +7 (918) 045-77-00 Наличные Плюс 0\r\n09:00 - 13:00 Краснодар, ул им Братьев Дроздовых, Дом 41, Кв. 19\n" +
                "\n5 RU161111-252357 PACK19697840 1 Ирина Концевик +7 (918) 045-77-00 Наличные Плюс 0\r\n09:00 - 13:00 Краснодар, ул им Братьев Дроздовых, Дом 41, Кв. 19\n" + "\n6 RU161104-298585 PACK19514804 3 Роман +7 (938) 435-93-29 Наличные Плюс 0 09:00 - 13:00\r\nКраснодар, фурманова, Дом 62 9.11\n";

            Regex regex = new Regex(@"\b([А-Я][а-я]+)\s+([А-Я][а-я]+)\b");
            MatchCollection matc = regex.Matches(text);
            string[] names = new string[matc.Count];
            for (int i = 0; i < matc.Count; i++)
            {
                string firstName = matc[i].Groups[1].Value;
                string lastName = matc[i].Groups[2].Value;
                names[i] = firstName + " " + lastName;
            }
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
        }
    }
}
