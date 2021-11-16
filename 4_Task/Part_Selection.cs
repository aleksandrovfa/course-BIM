using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Task
{
    class Part_Selection
    {
        static void Main(string[] args)
        {
            //Выбор задачи:
            Console.WriteLine("Напишите номер задачи(доступно 1,2,3)");
            int task = Convert.ToInt32(Console.ReadLine());
            switch (task)
            {
                case 1:
                    Part_1 part1 = new Part_1();
                    part1.MainPart_1();
                    break;
                case 2:
                    Part_2 part2 = new Part_2();
                    part2.MainPart_2();
                    break;
                case 3:
                    Part_3 part3 = new Part_3();
                    part3.MainPart_3();
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
