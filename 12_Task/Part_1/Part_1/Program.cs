using System;

namespace Part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] dfsf = new int[4];
            double pi = Math.PI;
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
                double area = Math.PI * Math.Pow(radius,2);
                return area;
            }
            public static bool PointInCircle(double radius, double x, double y, double x0 = 0, double y0 = 0)
            {
                double PointInCircle = Math.PI * Math.Pow(radius, 2);
                return PointInCircle;
            }
        }
    }
}
