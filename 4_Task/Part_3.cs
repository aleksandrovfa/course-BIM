using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Task
{
    class Part_3
    {
        public void MainPart_3()
        {
            Console.WriteLine("Введите число А");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число B");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число C");
            int C = Convert.ToInt32(Console.ReadLine());
            int a = A;
            int b;
            int count = 0;
            //Вычитаем сторону квадрата циклами из сторон
            while (a >= C)
            {
                b = B;
                a = a - C;
                while (b >= C)
                {
                    b = b - C;
                    count = count+1;
                }
            }
            Console.WriteLine("В прямоугольнике размером {0}x{1} уместилось {3} квадратов размером {2}x{2} ",A,B,C,count);
            Console.ReadKey();


        }
    }
}
