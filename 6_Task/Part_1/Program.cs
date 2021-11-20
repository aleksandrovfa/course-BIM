using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом. Знаки препинания не используются.");
            string line = Console.ReadLine();
            string[] arr = line.Split();


            //Определение длинны самого длинного слова 
            int lengthLine = 0;
            foreach (string item in arr)
            {
                if (lengthLine < item.Length)
                {
                    lengthLine = item.Length;
                }
            }


            //Запись в список самых длинные слов(их может быть несколько).
            List<string> words = new List<string>();
            foreach (string item in arr)
            {
                if (lengthLine == item.Length)
                {
                    words.Add(item);
                }
            }


            //Вывод самых длинных слов через запятую, если их несколько. 
            Console.Write("Вывод самых длинных слов: ");
            for (int i = 0; i < words.Count(); i++)
            {
                Console.Write(words[i].ToString());
                if (i<words.Count()-1)
                {
                    Console.Write(", ");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
