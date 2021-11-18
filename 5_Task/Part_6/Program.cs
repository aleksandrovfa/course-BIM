using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_6
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ввод и вывод массива
            Console.WriteLine("Введите N, где N это размер массива NxN");
            int sizeArray = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[sizeArray, sizeArray];
            for (int i = 0; i < sizeArray; i++)
            {
                for (int j = 0; j < sizeArray; j++)
                {
                    Console.WriteLine("Введите число {0} строки {1} столбца", i+1,j+1);
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("вывод массива:");
            for (int i = 0; i < sizeArray; i++)
            {
                for (int j = 0; j < sizeArray; j++)
                {
                    Console.Write("{0,3}", array[i, j]);
                }
                Console.WriteLine();
            }
            #endregion

            //Переменная которая меняется при не совпадении сумм
            bool magic = true;

            #region Проверка по строкам
            int summLineControl = 0;
            int summLine = 0;
            for (int i = 0; i < sizeArray; i++)
            {
                summLine = 0;
                for (int j = 0; j < sizeArray; j++)
                {
                    summLine += array[i,j];   
                }
                //Запись контрольной величины
                if (i == 0)
                {
                    summLineControl = summLine;
                }
                //Сравнение при подсчете каждой строки 
                if (summLineControl != summLine)
                {
                    magic = false;
                }
            }
            #endregion

            #region Проверка по столбцам
            int summColumnControl = 0;
            int summColumn = 0;
            for (int i = 0; i < sizeArray; i++)
            {
                summColumn = 0;
                for (int j = 0; j < sizeArray; j++)
                {
                    summColumn += array[j, i];
                }
                //Запись контрольной величины
                if (i == 0)
                {
                    summColumnControl = summColumn;
                }
                //Сравнение при подсчете каждой строки 
                if (summColumn != summColumnControl)
                {
                    magic = false;
                }
            }
            #endregion

            #region Проверка по двум диагоналям
            int digOne1 = 0;
            int digOne2 = 0;
            for (int i = 0; i < sizeArray; i++)
            {
                int j = i;
                digOne1 += array[i,j];
            }
            for (int i = sizeArray-1; i >= 0; i--)
            {
                int j = (sizeArray-1) - i;
                digOne2 += array[j, i];

            }
            if (digOne2 != digOne1)
            {
                magic = false;
            }
            #endregion

            if (magic)
            {
                Console.WriteLine("Данный массив является магическим квадратом");
            }
            else
            {
                Console.WriteLine("К сожалению это не магический квадрат");
            }
            Console.ReadKey();

        }
    }
}
