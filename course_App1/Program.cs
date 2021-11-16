using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_App1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину окружности(периметр): ");
            double L = Convert.ToInt32(Console.ReadLine());
            double R = L / (2 * Math.PI);
            double S = Math.PI * Math.Pow(R, 2);
            Console.WriteLine("Радиус круга равен = {0}",R);
            Console.WriteLine("Площадь круга равена = {0}", S);
            Console.ReadLine();
        }
    }
}
