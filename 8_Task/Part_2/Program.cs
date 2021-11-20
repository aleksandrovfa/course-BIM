using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int size = 10;//Количество числе для записи

            //Запись чисел в файл
            string path = "Text.txt";
            Random rand = new Random();
            StreamWriter sw = new StreamWriter(path);
            for (int i = 0; i < size; i++)
            {
                sw.Write(rand.Next(0, 10));
                sw.Write(" ");
            }
            sw.Close();


            //Чтение чисел из файла
            StreamReader sr = new StreamReader(path);
            string line = sr.ReadLine();


            //Нахождение суммы числе в файле. 
            int summ = 0;
            foreach (string item in line.Split())
            {
                if (item != "")
                {
                    summ += Convert.ToInt32(item);
                }
            }

            //Вывод в консоль
            Console.WriteLine("Сумма числе в файле равна {0}", summ);
            Console.ReadKey();
        }

    }
}
