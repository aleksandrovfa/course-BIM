using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом. Знаки препинания не используются.");
            string lineRead = Console.ReadLine();
            string[] arr = lineRead.Split();


            //Запись в строки в одну переменную String line слева направо 
            string line = null;
            foreach (string item in arr)
            {
                line += item.ToLower();
            }
            

            //Запись в строки в одну переменную String line cправо налево
            string lineReverse = null;
            foreach (string item in arr.Reverse())
            {
                string word = null;
                foreach (char i in item.ToLower().Reverse())
                {
                    word += i;
                }
                lineReverse += word;  
            }

            //Сравнение и вывод результата
            if (line == lineReverse)
            {
                Console.WriteLine("Данное пердложение полидром");
            }
            else
            {
                Console.WriteLine("Данное предложение не является полидромом");
            }

            Console.WriteLine(line);
            Console.WriteLine(lineReverse);
            Console.ReadKey();
        }
    }
}
