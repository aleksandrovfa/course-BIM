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
            double[] a = Input(1); //Запись в массив сторон треугольника
            double sa = GetArea(a); //Вычисление площади треугольника


            double[] b = Input(2);
            double sb = GetArea(b);

            Console.WriteLine("Площадь первого = {0,2}", sa.ToString("0.00"));
            Console.WriteLine("Площадь второго = {0}", sb.ToString("0.00"));

            if (sa>sb)
            {
                Console.WriteLine("Площадь первого больше");
            }
            else if (sb>sa)
            {
                Console.WriteLine("Площадь второго больше");
            }
            else
            {
                Console.WriteLine("Площади равны");
            }
            Console.ReadKey();


        } 
        static double[] Input (int num)
        {
            Console.WriteLine("Задайте {0} треугольник длинами сторон через пробел", num);
            string side = Console.ReadLine();
            string[] sideArrayString = side.Split();
            double[] sideArrayInt = new double[sideArrayString.Length];
            for (int i = 0; i < sideArrayString.Length; i++)
            {
                sideArrayInt[i] = Convert.ToDouble(sideArrayString[i]);
            }
            return sideArrayInt;
        }
        static double GetArea (double[] side)
        {
            //Проверка на существование треугольника.
            if (side[0] + side[1] > side[2] && side[0] + side[2] > side[1] && side[2] + side[1] > side[0])
            {
                double poluperimeter = (side[0] + side[1] + side[2]) / 2;
                double s = Math.Sqrt(poluperimeter * (poluperimeter - side[0]) * (poluperimeter - side[1]) * (poluperimeter - side[2]));
                return s;
            }
            else
            {
                Console.WriteLine("Такого треугольника не существует, площадь записана как 0");
                return 0;
            }
        } 
    }
}
