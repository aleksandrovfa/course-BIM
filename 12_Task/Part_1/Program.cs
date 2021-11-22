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
            //Координаты круга , радиус , координаты точи
            double centerX = 5;
            double centerY = 0;
            double radius = 3;
            double x = 2;
            double y = 0;
            Console.WriteLine("Радиус круга равен {0}", Math.Round(Circle.GetLength(radius),2));
            Console.WriteLine("Радиус круга равен {0}", Math.Round(Circle.GetArea(radius),2));


            //Определяет точка внутри круга или нет
            if (Circle.isPointInCircle(centerX, centerY, radius, x, y))
            {
                Console.WriteLine("Точка внутри круга");
            }
            else
            {
                Console.WriteLine("Точка за пределами круга");
            }
            Console.ReadKey();
        }

        public static class Circle
        {
            public static double GetLength(double radius)
            {
                double length = 2 * Math.PI * radius;
                return length;
            }

            public static double GetArea(double radius)
            {
                double area = Math.PI * Math.Pow(radius, 2);
                return area;
            }
            public static bool isPointInCircle(double centerX, double centerY, double radius, double x, double y)
            {
                double dx = centerX - x;
                double dy = centerY - y;
                dx *= dx;
                dy *= dy;
                double distanceSquared = dx + dy;
                double radiusSquared = radius * radius;
                return distanceSquared <= radiusSquared;
            }

        }
    }
}