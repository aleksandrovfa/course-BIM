using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите N, где N это размер массива NxN");
            int sizeArray = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[sizeArray,sizeArray];
            // переменная true отвечает за смену 0 и 1
            bool change = true;
            for (int i = 0; i < sizeArray; i++)
            {

                #region Смена первого числа в следующей строке при четном массиве
                if (i>0 && sizeArray % 2 == 0)
                {
                    //последний элемент в предыдущий строке
                    switch (array[i - 1, sizeArray-1])
                    {
                        case 1:
                            {
                                change = false;
                                break;
                            }
                        case 0:
                            {
                                change = true;
                                break;
                            }
                    }
                }
                #endregion


                #region Запись строки массива и вывод в консоль
                for (int j = 0; j < sizeArray; j++)
                {
                    if (change)
                    {
                        array[i, j] = 0;
                        change = false;
                    }
                    else
                    {
                        array[i, j] = 1;
                        change = true;
                    }

                    Console.Write("{0,2}", array[i, j]);
                }
                Console.WriteLine();
                #endregion
            }
            Console.ReadKey();
        }
    }
}
