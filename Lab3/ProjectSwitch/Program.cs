using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    {
                        Console.WriteLine("Понедельник");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("вторник");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Среда");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Четверг");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Пятница");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Суббота");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Воскресенье");
                        break;
                    }
                default:
                    Console.WriteLine("Ошибка");
                    break;
            }
            Console.ReadKey();
        }
    }
}
