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
            Console.WriteLine("Введите радиус окружности:");
            double R = Convert.ToDouble(Console.ReadLine());
            Func<double, double> func = new Func<double, double>(CircleLength);
            func += CircleArea;
            func += SphereVolume;
            func?.Invoke(R);
            Console.ReadKey();
        }
        static double CircleLength (double R)
        {
            double D = 2 * Math.PI * R;
            Console.WriteLine("Длина окружности равна {0:F2}", D);
            return D;
        }
        static double CircleArea (double R)
        {
            double S = Math.PI * Math.Pow(R, 2);
            Console.WriteLine("Площадь окружности равна {0:F2}", S);
            return S;
        }
        static double SphereVolume (double R)
        {
            double V = 4 / 3 * Math.PI * Math.Pow(R, 3);
            Console.WriteLine("Объем сферы равен {0:F2}", V);
            return V;
        }
    }
}
