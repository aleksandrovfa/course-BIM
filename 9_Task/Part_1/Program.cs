using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветсвует калькулятор!");
            float x, y, num;
            float result = 0;
            try
            {
                Console.Write("Введите целое число. X=");
                x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите целое число. Y=");
                y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите код операции:");
                Console.WriteLine("                      1 - сложение");
                Console.WriteLine("                      2 - вычитание");
                Console.WriteLine("                      3 - произведение");
                Console.WriteLine("                      4 - частное");
                Console.Write("Ваш выбор:");
                num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        result = x + y;
                        break;
                    case 2:
                        result = x - y;
                        break;
                    case 3:
                        result = x * y;
                        break;
                    case 4:
                        result = x / y;
                        break;
                    default:
                        Exception ex1 = new Exception("Нет операции с указанным номером");
                        throw ex1;
                }
                Console.WriteLine("Ваш результат = {0}",result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка! {0}",ex.Message);
            }
            Console.ReadKey();
        }
    }
}
