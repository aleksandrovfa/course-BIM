using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Homework
{
    class Task_Selection
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите номер задачи(доступно 1 и 3)");
            int task = Convert.ToInt32(Console.ReadLine());
            switch (task)
            {
                case 1:
                    Task_1 task1 = new Task_1();
                    task1.Main1();
                    break;
                case 3:
                    Task_3 task3 = new Task_3();
                    task3.Main3();
                    break;
                default:
                    Console.WriteLine("Задачи не обнаружено, закрываюсь");
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;

            }
        }
    }
}
