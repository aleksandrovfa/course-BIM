using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Part_1
{
    class Program
    {
        //Задание массива
        static int column = 50;
        static int line = 10;
        static int[,] area = new int[line, column];
        static void Main(string[] args)
        {
            ThreadStart threadStart = new ThreadStart(Gardener2);
            Thread myThread = new Thread(threadStart);
            myThread.Start();
            Gardener1();


            Console.WriteLine("Вывод участка: 1-первый садовник , 2-второй садовник");
            int gardener1 = 0;
            int gardener2 = 0;
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    switch (area[i, j])
                    {
                        case 1: gardener1++;break;
                        case 2: gardener2++;break;
                    }
                    Console.Write("{0,2}",area[i,j]);
                }
                Console.WriteLine();

            }
            Console.WriteLine("Первый садовник успел засеять: {0}, Второй: {1}", gardener1,gardener2);
            Console.ReadKey();
        }
        // Два метода садовников, которык заполняют массив.
        //Интересно то что если садовники не засыпают (даже 0 милисекунд) после каждой просеянной грядки, то садовник, который включился первый, успевает всё засеять.

        //Без приостановления потока ответ получается некорректный
        public static void Gardener1()
        {
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (area[i, j] == 0)
                    {
                        area[i, j] = 1;
                        //Переключение потока
                        Thread.Sleep(0);
                    }
                    else break;
                }

            }
        }
        public static void Gardener2()
        {
            for (int j = column - 1; j >= 0; j--)
            {
                for (int i = line - 1; i >= 0; i--)
                {
                    if (area[i, j] == 0)
                    {
                        area[i, j] = 2;
                        Thread.Sleep(0);
                    }
                    else break;
                }

            }
        }

    }

}
