using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1
{
    class Program
    {
        static public int sizeArray;
        static int[] array;
        static int sum = 0;
        static int max = 0;

        static void Main(string[] args)
        {
            #region Создание массива
            Console.WriteLine("Введите размер массива:");
            sizeArray = Convert.ToInt32(Console.ReadLine());
            array = new int[sizeArray];
            Random r = new Random();
            for (int i = 0; i < sizeArray; i++)
            {
                array[i] = r.Next(100);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            #endregion

            # region Создание task и из запуск
            Action action = new Action(ArraySum);
            Action<Task> action2 = new Action<Task>(ArrayMax);
            Task task1 = new Task(action);
            Task task2 = task1.ContinueWith(action2);
            task1.Start();
            #endregion

            task2.Wait();
            Console.WriteLine("Сумма чисел массива: " + sum);
            Console.WriteLine("Сумма чисел массива: " + max);


            Console.ReadKey();
        }
        static void ArraySum()
        {
            sum = array.Sum();
            Console.WriteLine("Нахождение суммы");
        }
        static void ArrayMax(Task task)
        {
            max = array.Max();
            Console.WriteLine("Нахождение максимального значения");
        }
    }
}
