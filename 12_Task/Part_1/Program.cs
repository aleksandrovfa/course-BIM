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
            //Console.WriteLine("Hello World!");
            //int[] dfsf = new int[4];
            //double pi = Math.PI;
            double centerX = 5;
            double centerY = 0;
            double radius = 3;
            double x = 2;
            double y = 0;
            if (Circle.isPointInCircle(centerX, centerY, radius, x, y))
            {
                Console.WriteLine("Точка внутри круга");
            }
            else
            {
                Console.WriteLine("Точка за пределами круга");
            }
            Console.ReadKey();
            //Circle.isPointInCircle(centerX,centerY,radius,x,y);
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