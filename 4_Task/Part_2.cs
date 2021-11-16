using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Task
{
    class Part_2
    {
        public void MainPart_2()
        {
            Console.WriteLine("Осуществите ввод последовательности целых чисел нажимая Enter, число 0 служит концом ввода");
            int i;
            int SumMinus = 0;
            int SumPlus = 0;
            do
            {
                i = Convert.ToInt32(Console.ReadLine());
                if (i>0)
                {
                    SumPlus++;
                }
                if (i<0)
                {
                    SumMinus++;
                }

            } while (i != 0);
            if (SumPlus > SumMinus)
            {
                Console.WriteLine("Больше положительных чисел");
            }
            if (SumPlus < SumMinus)
            {
                Console.WriteLine("Больше отрицательных чисел");
            }
            if (SumPlus == SumMinus)
            {
                Console.WriteLine("Одинаковое количество положительных и отрицательных чисел");
            }
            Console.ReadKey();

        }
    }
}
